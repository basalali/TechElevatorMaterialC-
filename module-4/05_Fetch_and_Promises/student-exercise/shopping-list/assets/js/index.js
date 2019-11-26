const button = document.querySelector(".loadingButton");
button.addEventListener("click",displayItems);
let listLoaded = false;

function displayItems(){
if(listLoaded == false){
fetch('assets/data/shopping-list.json')
.then((response) => {
return response.json();
})

.then((todos) => {
  if('content' in document.createElement('template')) {
    const list = document.querySelector("ul");
    todos.forEach((todo) => {
      const tmpl = document.getElementById('shopping-list-item-template').content.cloneNode(true);
      tmpl.querySelector("li").insertAdjacentHTML('afterbegin',todo.name);
      if( todo.completed ) {
        const circleCheck = tmpl.querySelector('.fa-check-circle');
        circleCheck.className += " completed";
      }
      list.appendChild(tmpl);
    });
  } else {
    console.error('Your browser does not support templates');
  }
})
.catch((err) => {console.error(err)});
}
listLoaded = true;
};