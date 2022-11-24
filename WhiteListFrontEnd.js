<!DOCTYPE html>
<html>
 
<head>
    <title>Enhanced White List</title>
    <script src='web3.min.js'></script>
</head>
 
<body>
 
    Enhanced White List
    <br />
    <button id= "createAccount"    onclick="createAccount();">Create Account</button>
<input type="text" id="newAccount" name="newAccount" <br/>
    <button id = "mint" onclick="mint();">Mint Currency</button>
<input type="text" id="mintAccount" name="mintAccount" >
<input type="text" id="mintAmount" name="mintAmount" <br/>
    <button id = "setSocial" onclick="setSocial();">Set social score </button>
<input type="text" id="socialAccount" name="socialAccount" >
<input type="text" id="score" name="score" <br/>
    <button id = "changeWL" onclick="changeWL();">Set White List</button>
	<input type="text" id="wlAccount" name="wlAccount" >
<input type="text" id="list" name="list" <br/>
    
    <br /><br />
    Status: <span id="status">Loading...</span>
 
    <script type="text/javascript">
        var contractAddress = '0xfA77f7e6be89BD5B07450aBED3448965Fdf8E2CE';
        var abi = [
{
		"inputs": [],
		"stateMutability": "nonpayable",
		"type": "constructor"
	},
	{
		"inputs": [
			{
				"internalType": "uint256",
				"name": "requested",
				"type": "uint256"
			},
			{
				"internalType": "uint256",
				"name": "available",
				"type": "uint256"
			}
		],
		"name": "InsufficientBalance",
		"type": "error"
	},
	{
		"inputs": [
			{
				"internalType": "uint256",
				"name": "score",
				"type": "uint256"
			}
		],
		"name": "antiReceiver",
		"type": "error"
	},
	{
		"inputs": [
			{
				"internalType": "uint256",
				"name": "score",
				"type": "uint256"
			}
		],
		"name": "antiSender",
		"type": "error"
	},
	{
		"inputs": [
			{
				"internalType": "address",
				"name": "subject",
				"type": "address"
			},
			{
				"internalType": "bool",
				"name": "listing",
				"type": "bool"
			}
		],
		"name": "changeWL",
		"outputs": [],
		"stateMutability": "nonpayable",
		"type": "function"
	},
	{
		"inputs": [
			{
				"internalType": "address",
				"name": "account",
				"type": "address"
			}
		],
		"name": "cleanAccount",
		"outputs": [],
		"stateMutability": "nonpayable",
		"type": "function"
	},
	{
		"inputs": [
			{
				"internalType": "address",
				"name": "newUser",
				"type": "address"
			}
		],
		"name": "createAccount",
		"outputs": [],
		"stateMutability": "nonpayable",
		"type": "function"
	},
	{
		"inputs": [
			{
				"internalType": "address",
				"name": "receiver",
				"type": "address"
			},
			{
				"internalType": "uint256",
				"name": "amount",
				"type": "uint256"
			}
		],
		"name": "mint",
		"outputs": [],
		"stateMutability": "nonpayable",
		"type": "function"
	},
	{
		"inputs": [
			{
				"internalType": "bool",
				"name": "listed",
				"type": "bool"
			}
		],
		"name": "notWhiteListed",
		"type": "error"
	},
	{
		"inputs": [
			{
				"internalType": "address",
				"name": "receiver",
				"type": "address"
			},
			{
				"internalType": "uint256",
				"name": "amount",
				"type": "uint256"
			}
		],
		"name": "send",
		"outputs": [],
		"stateMutability": "nonpayable",
		"type": "function"
	},
	{
		"anonymous": false,
		"inputs": [
			{
				"indexed": false,
				"internalType": "address",
				"name": "from",
				"type": "address"
			},
			{
				"indexed": false,
				"internalType": "address",
				"name": "to",
				"type": "address"
			},
			{
				"indexed": false,
				"internalType": "uint256",
				"name": "amount",
				"type": "uint256"
			}
		],
		"name": "Sent",
		"type": "event"
	},
	{
		"inputs": [
			{
				"internalType": "address",
				"name": "meta",
				"type": "address"
			},
			{
				"internalType": "uint256",
				"name": "score",
				"type": "uint256"
			}
		],
		"name": "setSocial",
		"outputs": [],
		"stateMutability": "nonpayable",
		"type": "function"
	},
	{
		"inputs": [
			{
				"internalType": "address",
				"name": "",
				"type": "address"
			}
		],
		"name": "balances",
		"outputs": [
			{
				"internalType": "uint256",
				"name": "",
				"type": "uint256"
			}
		],
		"stateMutability": "view",
		"type": "function"
	},
	{
		"inputs": [],
		"name": "minter",
		"outputs": [
			{
				"internalType": "address",
				"name": "",
				"type": "address"
			}
		],
		"stateMutability": "view",
		"type": "function"
	},
	{
		"inputs": [
			{
				"internalType": "address",
				"name": "",
				"type": "address"
			}
		],
		"name": "SocialScore",
		"outputs": [
			{
				"internalType": "uint256",
				"name": "",
				"type": "uint256"
			}
		],
		"stateMutability": "view",
		"type": "function"
	},
	{
		"inputs": [
			{
				"internalType": "address",
				"name": "",
				"type": "address"
			}
		],
		"name": "WhiteList",
		"outputs": [
			{
				"internalType": "bool",
				"name": "",
				"type": "bool"
			}
		],
		"stateMutability": "view",
		"type": "function"
	}
  ]
 
        async function loadWeb3() {
            if (window.ethereum) {
                window.web3 = new Web3(window.ethereum);
                window.ethereum.enable();
            }
        }
 
        async function loadContract() {
            return await new window.web3.eth.Contract(abi, contractAddress);
        }
 
        async function createAccount() {
            updateStatus('Creating account');
let value = document.getElementById("newAccount").value;
            const createAccount = await window.contract.methods.createAccount(value).call();
            updateStatus(`{value} account has been created’);
        }
 
        async function getCurrentAccount() {
            const accounts = await window.web3.eth.getAccounts();
            return accounts[0];
        }
 
        async function mint() {
            let value1 = document.getElementById("newAccount").value;
let value2 = document.getElementById("newAccount").value;
            updateStatus(`Minting…`);
            const mints = await window.contract.methods.mint(value1, value2).call();
            updateStatus('Minted');
        }
 
        async function setSocial() {
            let value1 = document.getElementById("socialAccount").value;
		let value2 = document.getElementById("score").value;
            updateStatus(`Setting social’);
            const settingSocial = await window.contract.methods.setSocial(value1, value2).call();
            updateStatus(`Social is set`);
        }
       
       
 
        async function changeWL() {
           let value1 = document.getElementById("wlAccount").value;
		let value2 = document.getElementById("list").value;
            updateStatus(`Changing white list status`);
            const whiteList = await window.contract.methods.changeWL(value1, value2).send();
            updateStatus('White list changed');
        }
 
        async function load() {
            await loadWeb3();
            window.contract = await loadContract();
            updateStatus('Ready!');
        }
 
        function updateStatus(status) {
            const statusEl = document.getElementById('status');
            statusEl.innerHTML = status;
            console.log(status);
        }
 
        load();
    </script>
</body>
 
</html>
