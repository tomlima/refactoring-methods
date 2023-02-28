/*----------------------------------- 
Before refactoring
-----------------------------------*/
personObj = {
    name: "Tom",
    age: 18,
}


function savePerson(personObj){
    personName = personObj.name;
    personAge = personObj.age;
    sql.insert(personName, personAge);
}


/*----------------------------------- 
After refactoring
-----------------------------------*/
personObj = {
    name: "Tom",
    age: 18,
}

function saveStudent(){
    sql.insert(personObj.name, personObj.age);
}
