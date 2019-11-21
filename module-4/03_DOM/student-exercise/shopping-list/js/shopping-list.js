// add pageTitle
/**
 @param {string} pageTitle  This should be set to 'My Shopping List'
 */
const pageTitle = "My Shopping List";

// add groceries
/**
 * 
 * @param {Array} groceries  This should be an array of 10 items for your shopping list. The items in the array can just be strings.
 */
const groceries = ["Milk", "Banana", "Bagels", "Juice", "Bread", "Juice" ,"Eggs", "Apples", "Carrots", "Candy"];
/**
 * This function will get a reference to the title and set its text to the value
 * of the pageTitle variable that was set above.
 */
function setPageTitle() 
{
  document.getElementById("title").innerHTML = pageTitle;

}

/**
 * This function will loop over the array of groceries that was set above and add them to the DOM.
 */
function displayGroceries() 

{
const list = document.getElementById("groceries");

groceries.forEach((item) =>{
  let li = document.createElement("li");
  let text = document.createTextNode(item);
  li.appendChild(text);
  
  list.appendChild(li);

});
  
}

/**
 * This function will be called when the button is clicked. You will need to get a reference
 * to every list item and add the class completed to each one
 */

 function markCompleted() {
   
    const tasks = document.querySelectorAll('li');

      tasks.forEach((task) => {
        task.setAttribute('class','completed');
      });
}
setPageTitle();

displayGroceries();



// Don't worry too much about what is going on here, we will cover this when we discuss events.
document.addEventListener('DOMContentLoaded', () => {
  // When the DOM Content has loaded attach a click listener to the button
  const button = document.querySelector('.btn');
  button.addEventListener('click', markCompleted);
});
