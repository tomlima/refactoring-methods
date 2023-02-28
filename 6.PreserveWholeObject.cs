/*------------------------------------------------------------------------ 
You get several values from an object and then pass them as parameters to a method.
Instead, try passing the whole object.
--------------------------------------------------------------------------*/


/*----------------------------------- 
Before refactoring
-----------------------------------*/
int low = daysTempRange.GetLow();
int high = daysTempRange.GetHigh();
bool withinPlan = plan.Range(low, high);


/*----------------------------------- 
After refactoring
-----------------------------------*/
bool withinPlan = plan.Range(daysTempRange);


