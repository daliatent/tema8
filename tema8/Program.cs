using tema8;


Tren tren = new Tren("Rapid 123");

GoodsVagon goodsVagon = new GoodsVagon(20000, 2010, "Cereale", 60);
tren.AddVagon(goodsVagon);

PersonVagon personVagon = new PersonVagon(1000, 2015, 80);
tren.AddVagon(personVagon);

FirstClassVagon FirstClassVagon = new FirstClassVagon(12000, 2018, 50);
tren.AddVagon(FirstClassVagon);

tren.LeaveStation();
tren.StopInStation();