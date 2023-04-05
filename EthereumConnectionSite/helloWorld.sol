pragma solidity ^0.8.0;

contract MessageStorage {
    string private message;
    address private owner;
    
    constructor() {
        owner = msg.sender;
    }
    
    function setMessage(string memory newMessage) public {
        require(msg.sender == owner, "Only contract owner can perform this action");
        message = newMessage;
    }
    
    function getMessage() public view returns (string memory) {
        return message;
    }
}