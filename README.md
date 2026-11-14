# MovieApi Proje Özeti

## Genel Bakış

MovieApi, .NET 10 üzerinde hazırlanmış katmanlı bir Web API projesidir. Çözüm; alan modeli, veri erişimi ve HTTP sunum katmanlarını ayrı projelerde tutar.

## Proje Yapısı

```text
MovieApi/
├── Core/
│   └── MovieApi.Domain/
│       └── Entities/
├── Infrastructure/
│   └── MovieApi.Persistence/
│       ├── Context/
│       └── Migrations/
└── Presentation/
	└── MovieApi.WebApi/
```

### Core / MovieApi.Domain

Uygulamanın temel alan varlıklarını içerir. Mevcut varlıklar:

- `Movie`: Film adı, afiş URL'si, puan, açıklama, süre, yayın tarihi, oluşturulma yılı ve aktiflik durumu.
- `Cast`: Oyuncu adı, soyadı, görseli, genel bakışı ve biyografisi.
- `Category`: Kategori bilgisi.
- `Review`: Kullanıcı yorumu, puanı, yorum tarihi ve durum bilgisi.
- `Tag`: Etiket bilgisi.

Bu proje yalnızca .NET 10 hedefler ve diğer katmanlara bağımlı değildir.

### Infrastructure / MovieApi.Persistence

Entity Framework Core ve SQL Server veri erişimini sağlar.

- `MovieContext`, `DbContext` sınıfından türetilmiştir.
- `Movies`, `Casts`, `Categories`, `Reviews` ve `Tags` için `DbSet` tanımları bulunur.
- SQL Server sağlayıcısı kullanılır.
- `Migrations` klasöründe ilk veritabanı migration'ı ve model snapshot'ı yer alır.
- Persistence katmanı `MovieApi.Domain` projesine referans verir.

### Presentation / MovieApi.WebApi

ASP.NET Core Web API giriş projesidir.

- Controller desteği etkinleştirilmiştir.
- Geliştirme ortamında OpenAPI dokümantasyonu sunulur.
- HTTPS yönlendirmesi ve yetkilendirme middleware'i eklenmiştir.
- Controller'lar için `Controllers` klasörü ayrılmıştır; mevcut kaynaklarda henüz controller implementasyonu bulunmamaktadır.
- Web API projesi `MovieApi.Persistence` katmanına referans verir.

## Teknoloji ve Paketler

- .NET 10 (`net10.0`)
- ASP.NET Core Web API
- Entity Framework Core 10
- SQL Server
- OpenAPI

## Veritabanı Notu

`MovieContext` içinde SQL Server bağlantı bilgisi doğrudan kod içerisinde tanımlıdır. Üretim ortamında bağlantı bilgisinin `appsettings.json`, kullanıcı sırları veya ortam değişkenleri üzerinden yönetilmesi önerilir.

## Mevcut Durum

Proje; domain varlıkları, EF Core context'i, migration altyapısı ve temel Web API başlangıç yapılandırmasını içerir. Film, kategori, oyuncu, yorum ve etiket işlemleri için controller, servis ve API endpoint'leri henüz eklenmemiştir.
