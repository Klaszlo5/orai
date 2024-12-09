let visibility = false;
let items = [];

window.addEventListener("DOMContentLoaded", () => {
  document.getElementById("show").value = "Lista megjelenítése";
  document.getElementById("listContainer").style.display = "none";
});

function toggleVisibility() {
  visibility = !visibility;
  return visibility;
}

document.getElementById("show").addEventListener("click", () => {
  if (toggleVisibility()) {
    document.getElementById("show").value = "Lista elrejtése";
    document.getElementById("listContainer").style.display = "block";
  } else {
    document.getElementById("show").value = "Lista megjelenítése";
    document.getElementById("listContainer").style.display = "none";
  }
});

function addNewItemToArray() {
  let item = document.getElementById("item").value;
  items.push(item);
  document.getElementById("item").value = "";
  document.getElementById("listContainer").innerHTML = "";
  displayList();
}

document.getElementById("submit").addEventListener("click", addNewItemToArray);

function displayList() {
  let container = document.getElementById("listContainer");
  let ul = document.createElement("ul");
  ul.classList.add("list-group");
  items.forEach((item, index) => {
    let li = document.createElement("li");
    li.classList.add(
      "list-group-item",
      "d-flex",
      "justify-content-between",
      "align-item-center"
    );
    li.textContent = item;
    let button = document.createElement("button");
    button.classList.add("btn", "btn-danger");
    button.textContent = "Törlés";
    li.append(button);
    li.setAttribute('id', `item_${index}`)
    ul.append(li);
    button.addEventListener('click', ()=>{
        deleteItem(index); 
    })
  });
  container.append(ul);
}

function deleteItem(index) {
    let li = document.getElementById(`item_${index}`);
    if (li){
    li.remove();
    let listItems = document.querySelectorAll('ul li');
    listItems.forEach((li, newIndex) => {
        li.setAttribute('id', `item_${newIndex}`);
        let button = li.querySelector('button');
        button.removeEventListener('click',deleteItem );
        button.addEventListener('click', () => {
            deleteItem(newIndex);
        });
    });
    }
    items.splice(index,1);
}
