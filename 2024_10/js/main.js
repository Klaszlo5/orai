let userLog = [];
function login() {
  let username = document.getElementById("username").value;
  let password = document.getElementById("password").value;
  let user = {
    Felhasznalonev: username,
    Jelszo: password,
  };
  userLog.push(user);
  generateList(userLog);
}

function generateList(data) {
  let ul = document.createElement("ul");
  ul.classList.add("list-group");
  for (let item of data) {
    for (let key in item) {
      let li = document.createElement("li");
      li.classList.add("list-group-item");
      li.textContent = `${key}: ${item[key]}`;
      ul.append(li);
    }
  }
  document.body.append(ul);
}
generateForm()
function generateForm() {
  let form = document.createElement("form");
  let usernameLabel = document.createElement("label");
  usernameLabel.setAttribute('for','name')
  usernameLabel.innerText = 'Kérem a neved'
  let usernameInput = document.createElement("input");
  usernameInput.setAttribute('id','name')
  usernameInput.setAttribute("type", "text");
  form.append(usernameLabel, usernameInput);
  document.body.append(form);
}
document.querySelector('p').innerText = "alma";