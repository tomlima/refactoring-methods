/*------------------------------------------------
Place the result of the expression or its parts 
in separate variables that are self-explanatory.
--------------------------------------------------*/


/*----------------------------------- 
Before refactoring
-----------------------------------*/
void RenderBanner() 
{
  if ((platform.ToUpper().IndexOf("MAC") > -1) &&
       (browser.ToUpper().IndexOf("IE") > -1) &&
        wasInitialized() && resize > 0 )
  {
    // do something
  }
}

/*----------------------------------- 
After refactoring
-----------------------------------*/
void RenderBanner() 
{
  bool isMacOs = platform.ToUpper().IndexOf("MAC") > -1;
  bool isIE = browser.ToUpper().IndexOf("IE") > -1;
  bool wasResized = resize > 0;

  if (isMacOs && isIE && wasInitialized() && wasResized) 
  {
    // do something
  }
}