# OOP Kavram Notlarım

## 1. Sınıf ile nesne farkı nedir? (`Member` ve `"Ayşe Yılmaz"` örneğiyle)

*Sınıf bir kalıp nesne ise o kalıptan üretilmiş bir örenektir
*Member üyenin id name e posta bilgilerinin olduğunu söyler tarif eder 
*new member diyip ayşe yılmazı oluşturunca gerçek bir üye oluşturmuş oluruz bu nesnedir

## 2. Parametreli constructor yazınca `new Member()` neden kırılır? Çözüm nedir?

*

## 3. `Book : LibraryItem` ne demek? `Member : IIdentifiable` neden miras değildir?

*LibraryItem bir sınıftır içinde kodlar vardır,IIdentifiable ise sadece bu sözleşmedir devralınıcak birşey olmadığı için miras değildir. Bir sınıf tek bir sınıftan miras alabilir ama birden çok ınterface uygulanabilir

## 4. BudgetTracker'deki `string[20]` + sayaç ile `List<Member>` farkı nedir?

*Dizi sabittir string[20] yazdıysak 20 adım ilerleriz ama list kendiliğinden büyüyen sistemdir add yaparsın eleman sayısını count ile öğrenirsin sayaç sistemi yoktur

## 5. `List` ne zaman, `Dictionary` ne zaman kullanılır? Id ile tek üye getirmek için hangisi?

*list tüm elemanları dolaşırken,dictionary hedef elemana gitmek isterken

## 6. `LibraryService` içindeki `_members` neden `private`?

*Dışarıdan doğrudan erişimi engellemek için privatedir. Private olunca üyelere erişmenin tek yolu servis metotlarrıdır

## 7. `BudgetService` ile `LibraryService` birbirine nasıl benzer?

*

## 8. `void Display()` ile `string GetSummary()` farkı nedir?
*Void display metni ekrana yazar geriye birşey döndürmez
*string getsummary ekrana bişey yazdırmaz metni hazırlar ve geri dödürür metinle ne yapılcagını biz seçeriz 


