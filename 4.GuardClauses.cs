
/*------------------------------------------------------------------------ 
Isolate all special checks and edge cases into 
separate clauses and place them before the main checks. 
Ideally, you should have a “flat” list of conditionals, one after the other.
--------------------------------------------------------------------------*/

/*----------------------------------- 
Before refactoring
-----------------------------------*/
double GetPayAmount(){
  double result;
  if (isDead)
  {
    result = DeadAmount();
  }
  else 
  {
    if (isSeparated)
    {
      result = SeparatedAmount();
    }
    else 
    {
      if (isRetired)
      {
        result = RetiredAmount();
      }
      else
      {
        result = NormalPayAmount();
      }
    }
  }
  
  return result;
}


/*----------------------------------- 
After refactoring
-----------------------------------*/
double GetPayAmount() {
  if (isDead){
    return DeadAmount();
  }
  if (isSeparated){
    return SeparatedAmount();
  }
  if (isRetired){
    return RetiredAmount();
  }
  return NormalPayAmount();
}