drop table phone
/
drop table register
/
create table phone(id number primary key, pname varchar(20), phone varchar(20), email varchar(20))
/
create table register(sno varchar(10), sname  varchar(20), id number,  primary key(sno,id), foreign key(id) references phone(id))
/
insert into phone values(1, 'ȫ�浿','010-111-1111', '111@bc.ac.kr')
/
insert into phone values(2, '�ڱ浿','010-222-2222', '222@bc.ac.kr')
/
insert into phone values(3, '�̱浿','010-333-3333', '333@bc.ac.kr')
/
insert into phone values(4, '��浿','010-444-4444', '444@bc.ac.kr')
/
insert into register values('a','��ǻ��',1)
/
insert into register values('b','�濵��',1)
/
insert into register values('c','�ڹ�',2)
/
insert into register values('a','��ǻ��',3)
/
