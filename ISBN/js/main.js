const books = [
  {
    ISBN: generateISBN(),
    title: "A Katedrális",
    author: "Raymond Carver",
    publisher: "Magvető Kiadó",
    published: 1981,
  },
  {
    ISBN: generateISBN(),
    title: "A Megálló",
    author: "Kazuo Ishiguro",
    publisher: "Magvető Kiadó",
    published: 2005,
  },
  {
    ISBN: generateISBN(),
    title: "Az utolsó előtti előadás",
    author: "Randy Pausch",
    publisher: "Gabo Kiadó",
    published: 2008,
  },
  {
    ISBN: generateISBN(),
    title: "Bűn és bűnhődés",
    author: "Fjodor Mihajlovics Dosztojevszkij",
    publisher: "Magvető Kiadó",
    published: 1866,
  },
  {
    ISBN: generateISBN(),
    title: "Kisasszonyok",
    author: "Louisa May Alcott",
    publisher: "Csengőkönyvek",
    published: 1868,
  },
  {
    ISBN: generateISBN(),
    title: "Az asszony a vörös kalapban",
    author: "Orhan Pamuk",
    publisher: "Magvető Kiadó",
    published: 2002,
  },
  {
    ISBN: generateISBN(),
    title: "A világ összes fénye",
    author: "Janne Teller",
    publisher: "Európa Könyvkiadó",
    published: 1996,
  },
  {
    ISBN: generateISBN(),
    title: "A Füveskönyv",
    author: "Mikszáth Kálmán",
    publisher: "Alexandra Kiadó",
    published: 1901,
  },
  {
    ISBN: generateISBN(),
    title: "Szent Johanna kúria",
    author: "Szabó Magda",
    publisher: "Magvető Kiadó",
    published: 1939,
  },
  {
    ISBN: generateISBN(),
    title: "Hűség",
    author: "Zsófia Ruttkay",
    publisher: "Libri Kiadó",
    published: 2017,
  },
  {
    ISBN: generateISBN(),
    title: "Az elveszett jelkép",
    author: "Dan Brown",
    publisher: "Gabo Kiadó",
    published: 2003,
  },
  {
    ISBN: generateISBN(),
    title: "Az ötödik hegy",
    author: "Paulo Coelho",
    publisher: "Magvető Kiadó",
    published: 1996,
  },
];
let headers = ['ISBN', 'Cim', 'Szerzo', 'Kiado', 'Kiadasi ev']
//TASK-1
// Keszitsen fuggvenyt generateISBN neven mely a kovetkezo keppen mukodik:
// letrehoz egy isben sorszamot melynek elso harom erteke fixen 978 ertek es ehhez meg 9 darab veletlen szamot hozzafuz a [0-10[ intervallumbol.
function generateISBN() {
  let ISBN = "978";
  for (let i = 0; i < 9; i++) {
    ISBN += Math.floor(Math.random() * 10);
  }
  return ISBN;
}
generateTable(books)
// TASK-2
// Keszitsen fuggvenyt amely legeneral egy tablazatot.
// Adja hozza a table, table-dark, table-striped osztalyokat.
// Hozzon letre egy <thead> es egy <tbody> elemet.
// Adja hozza a <thead> es <tbody> tag-eket a table-hoz
// Adja hozza a <table>-t a HTML <main> szemantikus elemehez.
// Hivja meg a generateThead fuggvenyt
function generateTable(data) {
  let table = document.createElement("table");
  table.classList.add("table", "table-dark", "table-striped");
  let thead = document.createElement("thead");
  let tbody = document.createElement("tbody");
  table.append(thead, tbody);
  // document.getElementById('app').append(table)
  generateThead(table,headers)
  document.querySelector("#app").append(table);
}
// TASK-3
// Keszitsen fuggvenyt amely letrehozza a <thead> tartalmat.
function generateThead(table,heads){
  let tr = document.createElement('tr');
  for (let item of heads){
    let th = document.createElement('th');
    th.textContent = item;
    tr.append(th);
  }
  table.querySelector('thead').append(tr);
}
