*// SPDX-License-Identifier: MIT*

pragma solidity ^0.8.9;

import "

[@openzeppelin/contracts/token/ERC20/ERC20.sol](https://github.com/OpenZeppelin/openzeppelin-contracts/blob/v4.8.1/contracts/token/ERC20/ERC20.sol)

";
import "

[@openzeppelin/contracts/security/Pausable.sol](https://github.com/OpenZeppelin/openzeppelin-contracts/blob/v4.8.1/contracts/security/Pausable.sol)

";
import "

[@openzeppelin/contracts/access/Ownable.sol](https://github.com/OpenZeppelin/openzeppelin-contracts/blob/v4.8.1/contracts/access/Ownable.sol)

";

contract EdensToken is ERC20, Pausable, Ownable {
    constructor() ERC20("EdensToken", "UAGE") {
        _mint(msg.sender, 100000 * 10 ** decimals());
    }

    function pause() public onlyOwner {
        _pause();
    }

    function unpause() public onlyOwner {
        _unpause();
    }

    function mint(address to, uint256 amount) public onlyOwner {
        _mint(to, amount);
    }

    function _beforeTokenTransfer(address from, address to, uint256 amount)
        internalwhenNotPaused
        override
    {
        super._beforeTokenTransfer(from, to, amount);
    }
}
