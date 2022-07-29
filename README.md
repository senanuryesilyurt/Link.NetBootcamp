# Link.NetBootcamp
.Net Bootcamp projelerini içerir.


## week-2-assignment

### Task 1 : EF Core API (CRUD) 
- Bir API projesi oluşturulacak
- EF Core implementasyonu yapılacak
- Bu API ile Temel CRUD işlemlerini yapılabilecek
- Katmanlı mimari uygulanacak
- Code First yaklaşımı kullanılacak

### Task 2 : SOLID prensiblerini uyguladığınız basit bir uygulama
- SOLID prensiplerini açıklayan bir console uygulaması.


## week-3-assignment

DDL (Data Definition language) İşlemleri

DML (Data Manipulation Language) İşlemleri

Tables

- Category
- Product
- ProductFeature

Category-Product (one to many)

Product-ProductFeature(one to one)

### Mimari Yapısı: 
1. Katmanlı mimariye ( 3-Layer)  uygun proje gerçekleştirilecek. 
2. Aşağıdaki pattern'lar projede kullanılacak. 
3. Swagger documentation her endpoint için kodlanacak. 
4. Her bir entity için controller sınıfları oluşturulacak. 
5. Temel Crud operasyonlarının yanında, projede  Stored Procedured / Function / View yapıları EF Core  kullanılarak örnek endpointler kodlanacak.
6. Kullanıcalak Patternler
	- GenericRepository
	- UnitOfWork
	- Transaction
	- API documentation comments (Swagger)*

7. Entities
	- Category
	- Product
	- ProductFeature


## week-4-assignment

- Token bazlı kimlik doğrulama Projesi (JWT ve RefreshToken oluşturmak ve doğrulamak)

(Tek proje veya katmanlı mimari ile oluşturulabilir)

- InMemory Cache ve Distributed Cache(Redis) ile ilgili proje.
