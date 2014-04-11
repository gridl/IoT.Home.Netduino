/***********************************************
***  Methods for the use case "delete book"  ***
************************************************/
pl.view.deleteBook = {
  // Initialize the deleteBook form
  setupUserInterface: function () {
    var deleteButton = document.getElementById("deleteButton");
    var selectEl = document.forms['Book'].selectBook;
    var key="", keys=[], book=null, bookOptionEl = null;
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
    deleteButton.addEventListener("click", 
        pl.view.deleteBook.handleDeleteButtonClickEvent);
    window.addEventListener("beforeunload", function () {
      Book.saveAllInstances(); 
    });
  },
  // Event handler for deleting a book
  handleDeleteButtonClickEvent: function () {
    var selectEl = document.forms['Book'].selectBook;
    var isbn = selectEl.value;
    if (isbn) {
      Book.deleteRow( isbn);
      selectEl.remove( selectEl.selectedIndex);
    }
  }
};