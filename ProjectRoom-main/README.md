ความเป็นมา
```
    เนื่องจากว่าห้องโปรมีคนเข้าใช้เป็นจำนวนมาก แต่ไม่สามารถรู้ได้ว่าใครเข้าใช้บ้าง จึงสร้างโปรแกรมนี้ขึ้นมา
```
วัตถุประสงค์ของโปรแกรม
```
    อยากรู้ว่าใครใช้บ้างโดยให้บอก ชื่อ นามสกุล สาขา และชั้นปี
```
Class Diagram
ClassDiagram
  direction LR
  Class Home {
  +private void onload()
  +private void button_submit_Click_1()
  +private void adminToolStripMenuItem_Click_1()
}
  Class LogIn {
  +private void button_login_Click_1()
}
  Class Admin {
  -public static Admin Instance
  -public List<Student> students = new List<Student>()
  -public string Username = "Admin"
  -public string Password = "1234"
  +private void openToolStripMenuItem_Click_1()
  +private void saveToolStripMenuItem_Click_1()
  +private void backToolStripMenuItem_Click()
}
  Class Person {
  -private string name
  -private string lastname
  -private string id
  -private string major
  -private string level
  +public string getName()
  +public string getLastName()
  +public string getID()
  +public string getMajor()
  +public string getLevel()
}
  Class Student {
  -private Person person
  -private string datein
  +public Person getPerson()
  +public string getDatein()
}
    Home --> LogIn
    Home --> Person
    Person --> Student
    LogIn --> Admin
    Admin --> Student


```
ชื่อผู้พัฒนา
```
นางสาว ชฎาพร พินิจสัย
```