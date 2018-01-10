Create database db_library_books



/* Creating Tables */

CREATE TABLE tbl_book (
	book_id VARCHAR(50) PRIMARY KEY NOT NULL,
	title VARCHAR(50) NOT NULL,
	publisher_name VARCHAR(50) NOT NULL
);

Create table tbl_book_authors (
	author_id INT PRIMARY KEY NOT NULL IDENTITY (1,1),
	book_id VARCHAR(50) NOT NULL,
	author_name VARCHAR(50) NOT NULL
);

Create table tbl_publisher (
	publisher_id INT PRIMARY KEY NOT NULL IDENTITY (1,1),
	publisher_name VARCHAR(50) NOT NULL,
	publisher_address VARCHAR(50) NOT NULL,
	publisher_phone VARCHAR(50) NOT NULL
);

Create table tbl_book_loans (
	loan_id INT PRIMARY KEY IDENTITY (1,1),
	book_id VARCHAR(50),
	branch_id VARCHAR(50) NOT NULL,
	card_no VARCHAR(50) NOT NULL,
	date_out VARCHAR(50) NOT NULL,
	due_date VARCHAR(50) NOT NULL
);

Create table tbl_borrower (
	borrower_id INT PRIMARY KEY IDENTITY (1,1),
	card_no VARCHAR(50) NOT NULL,
	borrower_name VARCHAR(50) NOT NULL,
	borrower_address VARCHAR(50) NOT NULL,
	borrower_phone VARCHAR(50) NOT NULL
);

Create table tbl_book_copies (
	copies_id INT PRIMARY KEY NOT NULL IDENTITY (1,1),
	book_id VARCHAR(50) NOT NULL,
	branch_id VARCHAR(50) NOT NULL,
	no_of_copies VARCHAR(50) NOT NULL
);

Create table tbl_library_branch (
	branch_id VARCHAR(50) PRIMARY KEY NOT NULL,
	branch_name VARCHAR(50) NOT NULL,
	branch_address VARCHAR(50) NOT NULL
);

/* Populating tables */

Insert into tbl_book
	(book_id, title, publisher_name)
	Values
	('book_01', 'The Lost Tribe', 'Picador'),
	('book_02', 'The Stand', 'Doubleday'),
	('book_03', 'Dreamcatcher', 'Scribner'),
	('book_04', 'It', 'Viking Press'),
	('book_05', 'Misery', 'Viking Press'),
	('book_06', 'A Game of Thrones', 'Bantam Spectra'),
	('book_07', 'A Clash of Kings', 'Bantam Spectra'),
	('book_08', 'A Storm of Swords', 'Bantam Spectra'),
	('book_09', 'A Feast for Crows', 'Bantam Spectra'),
	('book_10', 'A Dance with Dragons', 'Bantam Spectra'),
	('book_11', 'American Gods', 'William Morrow'),
	('book_12', 'Neverwhere', 'BBC Books'),
	('book_13', 'The Witness', 'G.P. Putnam Sons'),
	('book_14', 'Sweet Revenge', 'Bantam'),
	('book_15', 'Annihilation ', 'FSG'),
	('book_16', 'Authority', 'FSG'),
	('book_17', 'Acceptance', 'FSG'),
	('book_18', 'Jurassic Park', 'Alfred A. Knopf'),
	('book_19', 'The Lost World', 'Alfred A. Knopf'),
	('book_20', 'Sabriel', 'HarperCollins'),
	('book_21', 'Lirael', 'HarperCollins'),
	('book_22', 'Abhorsen', 'HarperCollins'),
	('book_23', 'The Hobbit', 'Allen & Unwin'),
	('book_24', 'The Fellowship of the Ring', 'Allen & Unwin'),
	('book_25', 'The Two Towers', 'Allen & Unwin'),
	('book_26', 'The Return of the King', 'Allen & Unwin'),
	('book_27', 'Catch-22', 'Simon & Schuster')
;

Insert into tbl_book_authors
	(book_id, author_name)
	Values
	('book_01', 'Mark Lee'),
	('book_02', 'Stephen King'),
	('book_03', 'Stephen King'),
	('book_04', 'Stephen King'),
	('book_05', 'Stephen King'),
	('book_06', 'George R.R. Martin'),
	('book_07','George R.R. Martin'),
	('book_08', 'George R.R. Martin'),
	('book_09', 'George R.R. Martin'),
	('book_10', 'George R.R. Martin'),
	('book_11', 'Neil Gaiman'),
	('book_12', 'Neil Gaiman'),
	('book_13', 'Nora Roberts'),
	('book_14', 'Nora Roberts'),
	('book_15', 'Jeff Vandermeer'),
	('book_16', 'Jeff Vandermeer'),
	('book_17', 'Jeff Vandermeer'),
	('book_18', 'Michael Crichton'),
	('book_19', 'Michael Crichton'),
	('book_20', 'Garth Nix'),
	('book_21', 'Garth Nix'),
	('book_22', 'Garth Nix'),
	('book_23', 'J.R.R. Tolkien'),
	('book_24', 'J.R.R. Tolkien'),
	('book_25', 'J.R.R. Tolkien'),
	('book_26', 'J.R.R. Tolkien'),
	('book_27', 'Joseph Heller')
;

Insert into  tbl_publisher
	(publisher_name, publisher_address, publisher_phone)
	Values
	('Picador', '175 Fifth Avenue, New York, NY 10010', '(646) 307-5745'),
	('Doubleday','1745 Broadway, New York, NY 10019', '(212) 782-9000'),
	('Sribner','157 Fifth Avenue, New York, NY 10010', '(212) 632-4915'),
	('Viking','625 Madison Avenue, New York, NY 10022', '(212) 366-2636'),
	('Viking','625 Madison Avenue, New York, NY 10022', '(212) 366-2636'),
	('Bantam Spectra', '884 Broadway, New York, NY 10019', '(212) 804-3077'),
	('Bantam Spectra', '884 Broadway, New York, NY 10019', '(212) 804-3077'),
	('Bantam Spectra', '884 Broadway, New York, NY 10019', '(212) 804-3077'),
	('Bantam Spectra', '884 Broadway, New York, NY 10019', '(212) 804-3077'),
	('Bantam Spectra', '884 Broadway, New York, NY 10019', '(212) 804-3077'),
	('William Morrow', '189 Broadway New York, NY 10007', '(212) 367-2244'),
	('BBC Books', '20 Vauxhall Bridge Road, London, SW1V 2SA UK', '(020) 8433 2000'),
	('G.P. Putnam Sons', '375 Hudson Street, New York, NY 10014', '(212) 366-2000'),
	('Bantam', '884 Broadway, New York, NY 10019', '(212) 804-3077'),
	('FSG', '175 Varick Street, 9th Floor, New York, NY 10014', '(212) 741-6900'),
	('FSG', '175 Varick Street, 9th Floor, New York, NY 10014', '(212) 741-6900'),
	('FSG', '175 Varick Street, 9th Floor, New York, NY 10014', '(212) 741-6900'),
	('Alfred A. Knopf', '1745 Broadway, 21st Floor, New York, NY 10019', '(212) 574-0030'),
	('Alfred A. Knopf', '1745 Broadway, 21st Floor, New York, NY 10019', '(212) 574-0030'),
	('HarperCollins', '10 E. 53rd Street, New York, NY 10022', '(212) 207-7000'),
	('HarperCollins', '10 E. 53rd Street, New York, NY 10022', '(212) 207-7000'),
	('HarperCollins', '10 E. 53rd Street, New York, NY 10022', '(212) 207-7000'),
	('Allen & Unwin', '83 Alexander St Crows Nest, NSW 2065, AUSTRALIA', '(61 2) 8425 0100'),
	('Allen & Unwin', '83 Alexander St Crows Nest, NSW 2065, AUSTRALIA', '(61 2) 8425 0100'),
	('Allen & Unwin', '83 Alexander St Crows Nest, NSW 2065, AUSTRALIA', '(61 2) 842  0100'),
	('Allen & Unwin', '83 Alexander St Crows Nest, NSW 2065, AUSTRALIA', '(61 2) 8425 0100'),
	('Simon & Schuster', '1230 Avenue of the Americas, New York, NY 10020', '(212) 698-7000')
;


Insert into  tbl_book_loans
	(book_id, branch_id, card_no, date_out, due_date)
	Values
	('book_01', 'branch_01', '0001', '12/04/2016', '01/08/2018'),
	('book_01', 'branch_02', '0002', '05/28/2016', '06/28/2016'),
	('book_01', 'branch_02', '0001', '11/04/2016', '12/04/2016'),
	('book_01', 'branch_03', '0003', '09/13/2016', '10/13/2018'),
	('book_02', 'branch_01', '0004', '04/29/2016', '01/09/2018'),
	('book_02', 'branch_04', '0005', '07/09/2016', '11/27/2018'),
	('book_02', 'branch_03', '0006', '06/08/2016', '02/25/2017'),
	('book_03', 'branch_02', '0007', '09/30/2016', '12/09/2018'),
	('book_03', 'branch_01', '0008', '01/24/2016', '01/10/2018'),
	('book_03', 'branch_02', '0008', '08/08/2016', '04/07/2017'),
	('book_03', 'branch_03', '0007', '04/19/2016', '03/23/2018'),
	('book_04', 'branch_04', '0006', '01/21/2016', '04/21/2017'),
	('book_04', 'branch_03', '0005', '11/26/2016', '09/25/2018'),
	('book_04', 'branch_02', '0004', '06/06/2016', '04/24/2017'),
	('book_05', 'branch_01', '0003', '06/03/2016', '01/07/2018'),
	('book_05', 'branch_01', '0002', '12/27/2016', '03/15/2017'),
	('book_05', 'branch_02', '0001', '12/12/2016', '11/17/2018'),
	('book_06', 'branch_03', '0002', '09/03/2016', '11/23/2017'),
	('book_06', 'branch_04', '0003', '10/10/2016', '06/11/2018'),
	('book_06', 'branch_03', '0004', '11/08/2016', '10/26/2017'),
	('book_06', 'branch_02', '0005', '08/14/2016', '11/14/2018'),
	('book_06', 'branch_01', '0006', '05/14/2016', '08/17/2017'),
	('book_07', 'branch_02', '0007', '12/09/2016', '09/23/2018'),
	('book_07', 'branch_03', '0008', '04/16/2016', '11/08/2017'),
	('book_07', 'branch_04', '0007', '07/05/2016', '11/15/2018'),
	('book_08', 'branch_04', '0006', '10/14/2016', '04/22/2017'),
	('book_08', 'branch_03', '0005', '03/05/2016', '12/06/2018'),
	('book_08', 'branch_02', '0004', '02/13/2016', '11/14/2017'),
	('book_09', 'branch_01', '0003', '12/07/2016', '11/19/2018'),
	('book_09', 'branch_01', '0002', '11/16/2016', '11/14/2017'),
	('book_10', 'branch_02', '0001', '08/19/2016', '10/18/2018'),
	('book_10', 'branch_03', '0002', '02/04/2016', '11/04/2017'),
	('book_10', 'branch_04', '0003', '01/12/2016', '12/19/2018'),
	('book_11', 'branch_03', '0004', '06/27/2016', '06/14/2017'),
	('book_11', 'branch_02', '0005', '09/16/2016', '11/29/2018'),
	('book_11', 'branch_01', '0006', '11/04/2016', '10/24/2017'),
	('book_12', 'branch_02', '0007', '05/17/2016', '09/10/2018'),
	('book_13', 'branch_03', '0008', '06/03/2016', '11/27/2017'),
	('book_13', 'branch_04', '0007', '07/24/2016', '11/14/2018'),
	('book_14', 'branch_03', '0006', '10/04/2016', '10/04/2017'),
	('book_15', 'branch_02', '0005', '02/18/2016', '11/22/2018'),
	('book_16', 'branch_01', '0004', '09/14/2016', '11/20/2017'),
	('book_17', 'branch_01', '0003', '03/20/2016', '06/12/2017'),
	('book_18', 'branch_02', '0002', '11/16/2016', '10/22/2017'),
	('book_19', 'branch_03', '0001', '09/07/2016', '05/13/2017'),
	('book_20', 'branch_04', '0002', '02/15/2016', '09/19/2017'),
	('book_21', 'branch_03', '0003', '12/31/2016', '01/01/2017'),
	('book_22', 'branch_02', '0004', '05/05/2016', '05/05/2017'),
	('book_23', 'branch_01', '0005', '12/12/2016', '09/08/2018'),
	('book_24', 'branch_02', '0006', '08/22/2016', '06/16/2017'),
	('book_25', 'branch_03', '0007', '04/16/2016', '12/16/2018'),
	('book_26', 'branch_04', '0008', '12/19/2016', '10/14/2017'),
	('book_27', 'branch_03', '0007', '10/04/2016', '10/04/2018')
; 

Insert into  tbl_borrower
	(card_no, borrower_name, borrower_address, borrower_phone)
	Values
	('0001', 'Bob Belcher', '365 Ocean Avenue, Tuckerton, NJ 08087', '(219) 884-9659'),
	('0002', 'Teddy Hunger', '212 Evergreen Terrace,Tuckerton, NJ 08087', '(219) 212-0909'),
	('0003', 'Ron Inspector', '13 Spooner Street, Tuckerton, NJ 08087', '(219) 772-1120'),
	('0004', 'Jimmy Pesto', '515 Pesto Lane, Tuckerton, NJ 08087', '(219) 705-7055'),
	('0005', 'Darryl Gamer', '99 Muddle Road, Tuckerton, NJ 08087', '(219) 444-2915'),
	('0006', 'Randy Filmer', '900 Screen Drive, Tuckerton, NJ 08087', '(219) 493-0903'),
	('0007', 'Critter Biker', '1414 One-Eye Lane, Tuckerton, NJ 08087', '(219) 704-0040'),
	('0008', 'Dr. Yap', '665 Cavity Road, Tuckerton, NJ 08087', '(219) 310-9019')
;

Insert into  tbl_book_copies
	(book_id, branch_id, no_of_copies)
	Values
	('book_01','branch_01', '10'),
	('book_02','branch_01', '10'),
	('book_03','branch_01', '10'),
	('book_04','branch_01', '10'),
	('book_05','branch_01', '10'),
	('book_06','branch_01', '10'),
	('book_07','branch_01', '10'),
	('book_08','branch_01', '10'),
	('book_09','branch_01', '10'),
	('book_10','branch_01', '10'),
	('book_02','branch_02', '10'),
	('book_04','branch_02', '10'),
	('book_11','branch_02', '10'),
	('book_12','branch_02', '10'),
	('book_13','branch_02', '10'),
	('book_14','branch_02', '10'),
	('book_15','branch_02', '10'),
	('book_16','branch_02', '10'),
	('book_17','branch_02', '10'),
	('book_18','branch_02', '10'),
	('book_19','branch_03', '10'),
	('book_20','branch_03', '10'),
	('book_21','branch_03', '10'),
	('book_01','branch_03', '10'),
	('book_23','branch_03', '10'),
	('book_24','branch_03', '10'),
	('book_25','branch_03', '10'),
	('book_26','branch_03', '10'),
	('book_27','branch_03', '10'),
	('book_05','branch_03', '10'),
	('book_06','branch_03', '10'),
	('book_19','branch_04', '10'),
	('book_15','branch_04', '10'),
	('book_16','branch_04', '10'),
	('book_17','branch_04', '10'),
	('book_10','branch_04', '10'),
	('book_11','branch_04', '10'),
	('book_04','branch_04', '10'),
	('book_01','branch_04', '10'),
	('book_24','branch_04', '10'),
	('book_25','branch_04', '10')
;

Insert into  tbl_library_branch
	(branch_id, branch_name, branch_address)
	Values
	('branch_01', 'Sharpstown', '1313 Bluewave Drive, Tuckerton, NJ 08087'),
	('branch_02', 'Central', '402 Occean Ave, Tuckerton, NJ 08087'),
	('branch_03', 'Eastside', '14 ToTheEast Road, Tuckerton, NJ 08087'),
	('branch_04', 'FifthQuadrant', '5 Not Lane, Tuckerton, NJ 08087')
;


/* Stored Procedures */

/* 1. Retrieve number of copies of The Lost Tribe owned by library branch Sharpstown, 
using bk as an alias for the Table tbl_book */

create procedure dbo.uspGetLostCopiesSharp
as
SELECT
		bk.title as [Title], tbl_book_copies.no_of_copies as [Number of Copies],
		branch_name as [Branch Name]
		FROM tbl_book AS bk
		INNER JOIN tbl_book_copies  ON bk.book_id = tbl_book_copies.book_id
		INNER JOIN tbl_library_branch  ON tbl_library_branch.branch_id = tbl_book_copies.branch_id	
		where bk.title = 'The Lost Tribe' and branch_name = 'Sharpstown'
;

[dbo].[uspGetLostCopiesSharp]

/* 2. Number of copies of The Lost Tribe owned by each library branch, using the alias bk for tbl_book */

create procedure dbo.uspGetLostCopies
as
SELECT
		bk.title as [Title], tbl_book_copies.no_of_copies as [Number of Copies],
		branch_name as [Branch Name]
		FROM tbl_book AS bk
		INNER JOIN tbl_book_copies  ON tbl_book_copies.book_id = bk.book_id
		INNER JOIN tbl_library_branch  ON tbl_library_branch.branch_id = tbl_book_copies.branch_id	
		where bk.title = 'The Lost Tribe'
;

[dbo].[uspGetLostCopies]


/* 3. Names of borrowers who do not currently have any books chcked out. This assumes borrowers returned their books by the due dates. */

create procedure dbo.uspGetOldNames
as
declare @Today date = getdate()
select
	tbl_borrower.borrower_name, tbl_book_loans.date_out, 
	tbl_book_loans.due_date
	from tbl_borrower
	inner join tbl_book_loans on tbl_book_loans.card_no = tbl_borrower.card_no
	where due_date <= @Today order by tbl_borrower.borrower_name


[dbo].[uspGetOldNames]

/* 4. Retrieve book title, plus borrower's name and address where borrowed from Sharpstown branch and due date is today. This assumes borrowers returned their books by the due dates. */

create procedure dbo.uspGetDueToday
as
declare @Today date = getdate()
select
	tbl_book.title, tbl_borrower.borrower_name, tbl_borrower.borrower_address
	from tbl_book
	inner join tbl_book_loans on tbl_book_loans.book_id = tbl_book.book_id
	inner join tbl_borrower on tbl_borrower.card_no = tbl_book_loans.card_no
	inner join tbl_library_branch on tbl_library_branch.branch_id = tbl_book_loans.branch_id
	where tbl_library_branch.branch_name = 'Sharpstown' and tbl_book_loans.due_date = @Today
;

[dbo].[uspGetDueToday]

/* 5. Get the branch name and number of books currently loaned out from each branch. This assumes borrowers returned their books by the due date. */

create procedure dbo.uspGetBooksOut
as
declare @Today date = getdate()
select
	tbl_library_branch.branch_name as [Branch], count(tbl_book_loans.due_date) as [Currently checked out books]
	from tbl_library_branch
	inner join tbl_book_loans on tbl_book_loans.branch_id = tbl_library_branch.branch_id
	where due_date >= @Today
	group by tbl_library_branch.branch_name
	having count(tbl_book_loans.due_date) >= 1
;

[dbo].[uspGetBooksOut]

/* 6. Retrieve names, address, and number of books checked out for borrowers with more than five books out. */

create procedure dbo.uspGetMoreBooks
as
declare @Today date = getdate()
select
	tbl_borrower.borrower_name as Name, tbl_borrower.borrower_address as Address, count(tbl_book_loans.card_no) as 'Currently checked out books'
	from tbl_borrower
	inner join tbl_book_loans on tbl_book_loans.card_no = tbl_borrower.card_no
	where tbl_book_loans.due_date > @Today
	group by tbl_borrower.borrower_name, tbl_borrower.borrower_address
	having count(tbl_book_loans.card_no) > 5
;

[dbo].[uspGetMoreBooks]

/* 7. Retrieve book titles of Stephen King's books, and the number of copies, only at the Central library branch. */

create procedure dbo.uspGetKingAtCentral
as
select
	tbl_book.title as [Title], tbl_book_copies.no_of_copies as [Number of Copies], tbl_library_branch.branch_name as [Branch]
	from tbl_book
	inner join tbl_book_copies on tbl_book_copies.book_id = tbl_book.book_id
	inner join tbl_library_branch on tbl_library_branch.branch_id = tbl_book_copies.branch_id
	inner join tbl_book_authors on tbl_book_authors.book_id = tbl_book.book_id
	where tbl_book_authors.author_name = 'Stephen King' and tbl_library_branch.branch_name = 'Central'
;

[dbo].[uspGetKingAtCentral]