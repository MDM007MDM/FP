ความเป็นมา
'''
    เนื่องจากว่าห้องโปรมีคนเข้าใช้เป็นจำนวนมาก แต่ไม่สามารถรู้ได้ว่าใครเข้าใช้บ้าง จึงสร้างโปรแกรมนี้ขึ้นมา
'''
วัตถุประสงค์ของโปรแกรม
'''
    อยากรู้ว่าใครใช้บ้างโดยให้บอก ชื่อ นามสกุล สาขา และชั้นปี
'''
Class Diagram
'''
    Class Home {
+private void onload 
+private void button_submit_Click_1
+private void adminToolStripMenuItem_Click_1
    }
    Class Log In {
+private void button_login_Click_1
    }
    Class Admin {
-public static Admin Instance;
-public List<Students> students = new List<Students>();
-public string Username = "Admin";
-public string Password = "1234";
+private void openToolStripMenuItem_Click_1
+private void saveToolStripMenuItem_Click_1
+private void backToolStripMenuItem_Click
    }
    Class Person {
-private string name;
-private string lastname;
-private string id;
-private string major;
-private string level;
+public string getName(){ return name; }
+public string getLastName(){ return lastname; }
+public string getID(){ return id; }
+public string getMajor(){ return major; }
+public string getLevel(){ return level; }
    }
    Class Student {
-private Person person;
-private string datein;
+public Person getPerson() { return person; }
+public string getDatein() { return datein; }
    }
    Home -- Log In
    Home -- Person -- Student
    Log In -- Admin
    Admin -- Student

'''
ชื่อผู้พัฒนา
'''
นางสาว ชฎาพร พินิจสัย
'''