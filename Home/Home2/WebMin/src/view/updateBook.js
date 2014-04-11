/***********************************************
***  Methods for the use case updateBook  ******
************************************************/
pl.view.updateBook = {
  // initialize the updateBook form
  setupUserInterface: function () {
    var selectEl = document.forms['Book'].selectBook;
    var isbnInpEl = document.forms['Book'].isbn;
    var titleInpEl = document.forms['Book'].title;
    var yearInpEl = document.forms['Book'].year;
    var updateButton = document.getElementById("updateButton");
    var key="", keys=[], book = null, bookOptionEl = null;
    // load all book objects
    Book.loadAllInstances();
    keys = Object.keys( Book.instances);
    // populate the selection list with books
    for (var i=0; i < keys.length; i++) {
      key = keys[i];
      book = Book.instances[key];
      bookOptionEl = document.createElement("option");
      bookOptionEl.text = book.title;
      bookOptionEl.value = book.isbn;
      selectEl.add( bookOptionEl, null);
    }
    // when a book is selected, populate the form with the data of the selected book
    selectEl.addEventListener("change", function () {
      key = selectEl.value;
      if (key) {
        book = Book.instances[key];
        isbnInpEl.value = book.isbn;
        titleInpEl.value = book.title;
        yearInpEl.value = book.year;
      } else {
        isbnInpEl.value = "";
        titleInpEl.value = "";
        yearInpEl.value = "";
      }
    });
    updateButton.addEventListener("click", 
        pl.view.updateBook.handleUpdateButtonClickEvent);
    window.addEventListener("beforeunload", function () {
      Book.saveAllInstances(); 
    });
  },
  // save session data
  handleUpdateButtonClickEvent: function () {
    var formEl = document.forms['Book'];
    var slots = { isbn: formEl.isbn.value, title: formEl.title.value, year: formEl.year.value};
    Book.updateRow( slots);
    formEl.reset();
  }
};