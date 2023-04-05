ความเป็นมา
```
    เนื่องจากว่าห้องโปรมีคนเข้าใช้เป็นจำนวนมาก แต่ไม่สามารถรู้ได้ว่าใครเข้าใช้บ้าง จึงสร้างโปรแกรมนี้ขึ้นมา
```
วัตถุประสงค์ของโปรแกรม
```
    อยากรู้ว่าใครใช้บ้างโดยให้บอก ชื่อ นามสกุล สาขา และชั้นปี
```
Class Diagram
```mermaid
classDiagram
  direction LR
  class Home{
  -cheakin():void
  -cheaout():void
  -Save():void
  -Clear():void
}
  class Login{
  -discountcode():void
  -pay():void
  -back():void
  }
  class Admin{
  -couponCode:string
  -minimumPice:double
  +creat(double min):void
  +getCoupon():void
  }
  class Person{
  -totalPice:double
  +Bill(pay double,getmoney Double):void
  +payBill():double
   }
  class student{
  -totalPice:double
  +Bill(pay double,getmoney Double):void
  +payBill():double
   }
  Home -- Login
  Home -- Person
  Login -- Admin
  Admin -- Student
  Student -- Person

```
ชื่อผู้พัฒนา
```
นางสาว ชฎาพร พินิจสัย
```