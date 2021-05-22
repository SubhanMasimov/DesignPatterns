# Singleton Design  Pattern
Singleton dizayn şablonu bir **creational** modeldir.
Bir classın obyektini təkrar-təkrar yaratmaq gərəkli olduğunda istifadə olunması məqsədəuyğundur.
Performansı qorumaq üçün istifadəçiyə ehtiyac duyduqda var olan bir obyekt veriləcək.
Bəs bunu necə edəcəyik?

Əvvəlcə bir **Singleton** sinifi yaradılır. Bu class-ın hər dəfə yeni obyektlərinin yaradılmasının qarşısını almaq üçün konstruktoru **private** etmək kifayət edəcəkdir.