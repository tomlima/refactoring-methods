/*------------------------------------------------------------------------ 
When one class does the work of two, awkwardness results.
Instead, create a new class and place the fields and methods responsible for the relevant functionality in it.
--------------------------------------------------------------------------*/

/*----------------------------------- 
Before refactoring
-----------------------------------*/
public class Student
{
    private string Name { get; set; }
    private string CPF { get; set; }
    private string DDD { get; set; }
    private string Phone { get; set; }

    public String getStudentName(){
        return this.Name;
    }

    public String getFullNumber(){
        return "(" + this.DDD + ") " + this.Phone;
    }
}



/*----------------------------------- 
After refactoring
-----------------------------------*/
public class Student
{
    private string Name { get; set; }
    private string CPF { get; set; }
    private Phone Phone { get; set; }
    public String getStudentName(){
        return this.Name;
    }
}

public class Phone
{
    private string DDD { get; set; }
    private string Phone { get; set; }
    public String getFullNumber(){
        return "(" + this.DDD + ") " + this.Phone;
    }
}