// SPDX-License-Identifier: GPL-3.0
pragma solidity ^0.8.4;

contract WhiteListCoin {
    // The keyword "public" makes variables
    // accessible from other contracts
    address public minter;
    mapping (address => uint) public balances; //tells the contract how much your balance
    mapping (address => uint) public SocialScore;
    mapping (address => bool) public WhiteList; //likely need this to be mapping from address to mapping address, whitelist is a list of addresses that you can send money to

    event Sent(address from, address to, uint amount);// Events allow clients to react to specific, contract changes you declare

constructor() {
        minter = msg.sender;
}
  
function createAccount(address newUser) public  {
    balances[newUser] = 0;
		WhiteList[newUser] = true;
		SocialScore[newUser] = 5;	
}

function mint(address receiver, uint amount) public {
        require(msg.sender == minter);
        balances[receiver] += amount;
    }

function wlStatus(address subject, bool listing) public 
 {
		require(msg.sender == minter);
    WhiteList[subject] = listing;
}


    error InsufficientBalance(uint requested, uint available);
		error notWhiteListed(bool listed);
		error antiSender(uint score);
		error antiReceiver(uint score);
    

    function send(address receiver, uint amount) public {
			
			require(msg.sender == minter);
        if (amount > balances[msg.sender])
            revert InsufficientBalance({
                requested: amount,
                available: balances[msg.sender]
            });
				if (WhiteList[receiver] == false)
            revert notWhiteListed({
                listed: WhiteList[receiver]
            });
				if (SocialScore[msg.sender] <= 1)
            revert antiSender({
                score: SocialScore[msg.sender]
            });
				if (SocialScore[receiver] <= 1)
            revert antiReceiver({
                score: SocialScore[receiver]
            });
			
        balances[msg.sender] -= amount;
        balances[receiver] += amount;
        emit Sent(msg.sender, receiver, amount);//emit sends a console message
    }

    function cleanAccount(address account) public{
        require(msg.sender == minter);
        balances[account] = 0;


    }
}
