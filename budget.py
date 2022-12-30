class Category:

    def __init__(self, name):
        self.name = name
        self.ledger = list()

    def __str__(self):
        title = f"{self.name:*^30}\n"
        items = ""
        total = 0
        for item in self.ledger:
            items += f"{item['description'][0:23]:23}" + f"{item['amount']:>7.2f}" + '\n'
            total += item['amount']
        output = title + items + "Total: " + str(total)
        return output

    def deposit(self, amount, description=""):
        """
        Adds an obj to the ledger list with a default string
        of "" and an amount
        """
        self.ledger.append({"amount": amount, "description": description})

    def withdraw(self, amount, description=""):
        """
        like deposit except subtracts the amount
        """

        if(self.check_funds(amount)):
            self.ledger.append({"amount": -amount, "description": description})
            return True;
        return False

    def get_balance(self):
        """
        Returns balance at present time"
        """
        total_cash = 0
        for item in self.ledger:
            total_cash += item["amount"]

        return total_cash

    def transfer(self, amount, category):
        """
        Sends money to a different category
        """
        if(self.check_funds(amount)):
            self.withdraw(amount, "Transfer to " + category.name)
            category.deposit(amount, "Transfer from " + self.name)
            return True
        return False

    def check_funds(self, amount):
        """
        False if amount is bigger than budget category balance
        """
        if(self.get_balance() >= amount):
            return True
        return False

    def get_withdrawls(self):
        total = 0
        for item in self.ledger:
            if item["amount"] < 0:
                total += item["amount"]
        return total
