ความเป็นมา
```
    เนื่องจากว่าห้องโปรมีคนเข้าใช้เป็นจำนวนมาก แต่ไม่สามารถรู้ได้ว่าใครเข้าใช้บ้าง จึงสร้างโปรแกรมนี้ขึ้นมา
```
วัตถุประสงค์ของโปรแกรม
```
    อยากรู้ว่าใครใช้บ้างโดยให้บอก ชื่อ นามสกุล สาขา และชั้นปี
```
Class Diagram
```Mermaid
classDiagram
  direction LR
  class Home{
  -onload():void 
}
  class LogIn{
  +button_login_Click_1():void
  }
  class Admin{
  -Username:string 
  -Password :string
  }
  class Person{
  -name;
  -lastname;
  -id:string
  -major:string
  -level:string
  +getName()
  +getLastName()
  +getID()
  +getMajor()
  +getLevel()
  }
  class Student{
  -person:Person
  -datein:string
  +getPerson():void
  +getDatein():void
  }
   Home -- LogIn
   Home -- Person 
   Person -- Student
   Log In -- Admin
   Admin -- Student

```
ชื่อผู้พัฒนา
```
นางสาว ชฎาพร พินิจสัย
```