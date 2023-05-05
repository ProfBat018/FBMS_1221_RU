select * from Groups
select * from Students

select AVG(GPA) from Students

select Groups.Name, AVG(Students.GPA) as AverageGPA
from Students
         inner join Groups on Students.GroupID = Groups.ID
group by Groups.Name


select Salary, Name, Age, Email
from Teachers
inner join Person P on P.Id = Teachers.PersonId
where Salary = (select Min(Salary) from Teachers)

select * from Students

select Person.Name, Groups.Name, Students.GPA from Students
inner join Groups on Groups.Id = Students.GroupId
inner join Person on Person.Id = Students.PersonId
where GroupId = 5


select * from Groups




