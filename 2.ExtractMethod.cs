/*--------------------------------------------------- 
Move this code to a separate new method (or function) 
and replace the old code with a call to the method.
-----------------------------------*/

/*----------------------------------- 
Before refactoring
-----------------------------------*/
void printNFE() {
  printBanner();

  // Print details.
  Console.WriteLine("name: " + getName());
  Console.WriteLine("amount: " + getOutstanding());  
}


/*----------------------------------- 
After refactoring
-----------------------------------*/
void printOwing() {
  printBanner();
  printDetails(getName(), getOutstanding());
}

void sendEmail(){
  //
}
  
void printDetails(string name, double outstanding) {
  Console.WriteLine("name: " + name);
  Console.WriteLine("amount: " + outstanding);
}



