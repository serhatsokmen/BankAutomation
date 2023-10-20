# C#-Bank-Automation

a bank automation where users and an authorized person can log in.

- with the user login, the logged-in user can withdraw money, deposit money, make money orders, change his password, view account movements
- no less than 10 deposits can be made during the deposit process
- when making a money transfer, an additional 2 liras is deducted from the money sent.
- during the password change process, the user must type the new password twice, which will be created after typing the old password.
- the user can view money transfers made during account transactions, the password change process if the password has been changed, deposits and withdrawals.
- for authorized login, the username is "admin" and the password is "456".
- in authorized transactions; there are customer discovery, customer update, customer deletion, customer addition, customer listing operations.
- in the customer addition section, the customer's information is taken and the data is identified.
- in the customer update; only the customer's first/last name, address, phone number can be updated. Gender, balance, id number and TC number cannot be changed.
- in the customer deletion process, the deleted customer is not deleted from the database. When the activity state is 1, it becomes 0. This is because account movements are not lost.
- in the customer listing process, customers can also be listed by name, where they can normally be listed.
- there are also registration and forgot password sections on the login screen of the automation.
- if the user does not have an account, he can register for automation after entering his own information by clicking register.(this information is recorded in the database.)
- if the user has forgotten his password, he can create a new password by clicking on the Forgot password option and entering the tc number and phone number correctly.
  
