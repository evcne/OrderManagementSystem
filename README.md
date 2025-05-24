# Order Management System

Bu proje, mikroservis mimarisi ile geliştirilen bir Sipariş Yönetim Sistemi'dir. .NET 8, Entity Framework Core, RabbitMQ, Elasticsearch, Quartz.NET ve SignalR gibi teknolojiler kullanılmıştır. 
Projenin temel amacı, e-ticaret altyapısında siparişlerin alınması, saklanması, işlenmesi, bildirilmesi ve aranabilir hale getirilmesini sağlamaktır.

Kullanılan Teknolojiler ve Amaçları:
- `.NET Core + C#	API ve Worker servislerinin temeli,
- `RESTful API	Sipariş CRUD ve durum sorgulama uçları,
- `MS SQL Server	Sipariş ve kullanıcı verilerini saklama,
- `Entity Framework Core	ORM aracı olarak veritabanı işlemleri,
- `Dapper	Performans kritik sorgular için mikro optimizasyon,
- `RabbitMQ	Siparişlerin işlenmesi için mesaj kuyruğu,
- `Elasticsearch	Siparişleri duruma, kullanıcıya göre aramak için,
- `Quartz.NET	Sipariş durum kontrolü ve planlı işler,
- `SignalR	Canlı bildirim sistemi (örneğin sipariş durumu değiştiğinde),
- `SOLID + OOP	Katmanlı mimari: Controller, Service, Repository, DTO, ViewModel, Mapping vs.,
- `Git	Anlamlı branch yapısı ve temiz commit geçmişi,
- `Clean Architecture	API, Application, Domain, Infrastructure katmanları,
- `Unit Test (opsiyonel)	xUnit ile Service/Repository katmanları test edilir.

Pull request’ler ve geri bildirimler **memnuniyetle karşılanır**. Projeye katkı sağlamak istiyorsanız lütfen önce bir issue oluşturun ve önerinizi tartışalım.
Kod katkılarınız için lütfen `main` branch yerine `feature/` isimli dallardan PR gönderin.

📌 Project Summary (English)
This is a microservice-based Order Management System project built using ASP.NET Core 8, Entity Framework Core, RabbitMQ, Elasticsearch, Quartz.NET, and SignalR.
The system is designed for an e-commerce infrastructure to receive, store, process, notify, and search orders efficiently.

Technologies & Purpose:
- `.NET Core + C#	Base structure for API and Worker services
- `RESTful API	Endpoints for CRUD and order status retrieval
- `MS SQL Server	Persistent storage for orders and user data
- `Entity Framework Core	ORM for database operations
- `Dapper	Used in performance-critical queries
- `RabbitMQ	Message queue for processing orders
- `Elasticsearch	Enables searching orders by status, user, etc.
- `Quartz.NET	Scheduled tasks for processing order states
- `SignalR	Real-time notifications for order updates
- `SOLID + OOP	Layered architecture: Controller, Service, Repository, DTO, ViewModel, Mapping
- `Git	Logical branch structure and clean commit history
- `Clean Architecture	Layers: API, Application, Domain, Infrastructure
- `Unit Test (optional)	xUnit tests for Service/Repository layers

**Pull requests and feedback are welcome.** If you'd like to contribute, please open an issue first to discuss your proposal. When contributing code, use a `feature/` branch instead of `main`.

## 📁 Katmanlar

- `Entities`: Model sınıfları
- `Data`: DbContext ve veritabanı konfigürasyonu
- `Repositories`: Veritabanı işlemlerini yöneten sınıflar
- `Services`: İş mantığını içeren sınıflar
- `Controllers`: API uç noktaları

## ⚙️ Kurulum

### Gereksinimler

- .NET 8 SDK
- SQL Server
- Visual Studio Code veya Visual Studio

### Kurulum Adımları

1. Repo'yu klonla:
   ```bash
   git clone https://github.com/kullaniciAdi/projeAdi.git
   cd projeAdi
