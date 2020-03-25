create table tbl_mov(
	datahora datetime,
	username varchar(20),
	produto varchar(50),
	foreign key (username) references tbl_login(username),
	foreign key (produto) references tbl_stock(ref),
	primary key (username, datahora)
)