let itemList = [];

export function addItem(newItem) {
  if (newItem.trim()) {
    itemList.push(newItem.trim());
    return true;
  }
  return false;
}

function deleteItem(index) {
  itemList.splice(index, 1);
}

export function renderList(containerId) {
  const listContainer = document.getElementById(containerId);
  listContainer.innerHTML = "";

  const ul = document.createElement("ul");
  ul.classList.add("list-group");

  itemList.forEach((item, index) => {
    const li = createListElement(item, index);
    ul.appendChild(li);
  });

  listContainer.appendChild(ul);
}

function createListElement(item, index) {
  const li = document.createElement("li");

  li.classList.add(
    "list-group-item",
    "d-flex",
    "justify-content-between",
    "align-items-center"
  );

  li.textContent = item;
  li.id = `item_${index}`;

  const deleteButton = createDeleteButton(index);
  li.appendChild(deleteButton);

  return li;
}

function createDeleteButton(index) {
  const deleteButton = document.createElement("button");

  deleteButton.classList.add("btn", "btn-danger");
  deleteButton.textContent = "Törlés";
  deleteButton.addEventListener("click", () => {
    deleteItem(index);
    renderList("listContainer")
  });

  return deleteButton;
}
