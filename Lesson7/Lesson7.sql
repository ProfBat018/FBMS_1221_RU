---- Что такое left и right join и в чем их отличие?
-- use Store;
-- select * from BoughtProducts
-- right join Receipt on BoughtProducts.Id = Receipt.BoughtProductsId


---- Что такое подзапросы ? Как с ними работать ?

insert into Product(Title, QRCode, ProductionDate, ExpirationTime) (select Title, QRCode, ProductionDate, ExpirationTime
                                                                    from Product
                                                                    where Id = 1)

select *
from Product
where Id in (select ProductId
             from BoughtProducts
                      inner join Receipt on BoughtProducts.Id = Receipt.BoughtProductsId
             where Receipt.Id = 1)




