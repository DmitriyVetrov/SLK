
create table [inf_user] (
	id int identity(1,1) not null primary key,
	first_name varchar(max) not null,
	last_name varchar(max) not null,
	email varchar(max) not null,
	pass varchar(max) not null,
	avatar varchar(max) not null,
	creation_date datetime not null,
	record_state int not null
)

create table [inf_category] (
	id int identity(1,1) not null,
	parent_id int,
	title varchar(max) not null,
	subtitle varchar(max) not null,
	creation_date datetime not null,
	record_state int not null

	primary key (id)
)

create table [inf_article] (
	id int identity(1,1) not null,
	title varchar(max) not null,
	body varchar(max) not null,
	category_id int not null,
	user_id int not null,
	creation_date datetime not null,
	record_state int not null

	primary key (id),
	foreign key (category_id) references inf_category(id),
	foreign key (user_id) references inf_user(id)
)


create table [inf_article_picture] (
	id int identity(1,1) not null,
	picture varchar(max) not null,
	article_id int not null,
	order_num int not null,
	creation_date datetime not null,
	record_state int not null

	primary key (id),
	foreign key (article_id) references inf_article(id)
)

create table [inf_comments] (
	id int identity(1,1) not null,
	body varchar(max) not null,
	user_id int not null,
	article_id int not null,
	creation_date datetime not null,
	record_state int not null

	primary key (id),
	foreign key (article_id) references inf_article(id),
	foreign key (user_id) references inf_user(id)
)

drop table [inf_comments]
drop table [inf_article_picture]
drop table [inf_article]
drop table [inf_category]
drop table [inf_user]