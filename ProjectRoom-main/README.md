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
  +button_submit_Click_1():void
  +adminToolStripMenuItem_Click_1():void
}
  class LogIn{
  +button_login_Click_1():void
  }
  class Admin{
  -Admin Instance;
  -List<Students> students 
  -Username 
  -Password 
  +openToolStripMenuItem_Click_1():void
  +saveToolStripMenuItem_Click_1():void
  +backToolStripMenuItem_Click():void
  }
  class Person{
  -name;
  -lastname;
  -id;
  -major;
  -level;
  +getName()
  +getLastName()
  +getID()
  +getMajor()
  +getLevel()
  }
  class Student{
  -person;
  -datein;
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