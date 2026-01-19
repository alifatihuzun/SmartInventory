# 📦 SmartInventory Microservices

![DotNet](https://img.shields.io/badge/.NET-8.0-512BD4?style=flat&logo=dotnet)
![Docker](https://img.shields.io/badge/Docker-Enabled-2496ED?style=flat&logo=docker)
![Architecture](https://img.shields.io/badge/Architecture-Microservices-orange?style=flat)
![License](https://img.shields.io/badge/License-MIT-green)

**SmartInventory**, modern e-ticaret ve stok yönetim ihtiyaçları için tasarlanmış, ölçeklenebilir ve modüler bir **Mikroservis** projesidir. Proje, farklı iş alanlarını (Identity, Ürün, Sipariş, Tedarikçi) izole ederek **Docker** üzerinde çalışacak şekilde yapılandırılmıştır ve tüm trafik **Ocelot API Gateway** üzerinden yönetilir.

---

## 🏗️ Mimari ve Teknolojiler

Bu proje **Clean Architecture** prensipleri gözetilerek geliştirilmiştir.

* **Core Framework:** ASP.NET Core 8 Web API
* **API Gateway:** Ocelot
* **Containerization:** Docker & Docker Compose
* **Database:** SQL Server (Entity Framework Core Code-First)
* **Authentication:** JWT (JSON Web Token) Identity Service
* **Communication:** RESTful HTTP

---

## 🧩 Servisler (Microservices)

Sistem aşağıdaki bağımsız servislerden oluşur:

| Servis Adı | Açıklama |
| :--- | :--- |
| **🛡️ Gateway** | `SmartInventory.Gateway` - Tüm dış istekleri karşılayan, yönlendiren ve güvenliği sağlayan tek giriş noktası (Ocelot). |
| **👤 Identity** | `SmartInventory.Services.Identity` - Kullanıcı kaydı, girişi ve JWT token üretimi işlemlerini yönetir. |
| **📦 Product** | `SmartInventory.Services.Product` - Ürün ekleme, güncelleme, stok takibi ve listeleme işlemlerini yapar. |
| **🛒 Order** | `SmartInventory.Services.Order` - Sipariş oluşturma ve sipariş durumlarını yönetir. |
| **🚚 Supplier** | `SmartInventory.Services.Supplier` - Tedarikçi firma bilgilerini ve ürün tedarik süreçlerini yönetir. |
