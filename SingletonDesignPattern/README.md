# Singleton Design  Pattern
Singleton dizayn şablonu bir **creational** modeldir.
Bir classın obyektini təkrar-təkrar yaratmaq gərəkli olduğunda istifadə olunması məqsədəuyğundur.
Performansı qorumaq üçün istifadəçiyə ehtiyac duyduqda var olan bir obyekt veriləcək.
Bəs bunu necə edəcəyik?

Əvvəlcə bir **Singleton** sinifi yaradılır. Bu class-ın hər dəfə yeni obyektlərinin yaradılmasının qarşısını almaq üçün konstruktoru **private** etmək kifayət edəcəkdir.
İstifadəçiyə isə bir **Singleton** dönən static və public bir metod təqdim edəcəyik. GetSingleton() metodu geriyə class içində private tanımladığımız Singleton tipində _singleton adlı field dönəcək.
Lakin öncə bir şərt yoxlanılmalıdır: bu classın obyekti ilk dəfə yaradılıbmı ya yox. Bəsit bir if şərti ilə null olduğu halda _singleton-a yeni obyekti mənimsədirik. İkinci dəfə isə artıq null olmadığına görə geriyə _singleton dönəcək.

**Program.cs** faylında singleton1 və singleton2 obyektlərinin referanslarının bərabərliyi yoxlanıldı və son çıxış: "equals".
Beləliklə dəfələrlə obyekt yaratmağa ehtiyac olmadan bir class nümunəsindən bu model sayəsində istifadə edə bilirik.