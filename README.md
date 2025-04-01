# 🌐 E-Ticaret Sipariş Yönetim Sistemi API Dökümantasyonu

Bu döküman, ASP.NET Core Web API ile geliştirilmiş temel bir e-ticaret sipariş yönetim sisteminin API endpoint'lerini ve çıktılarını açıklamaktadır.

## ✨ Temel URL
```
https://localhost:{port}/api
```
> Not: `{port}` Visual Studio tarafından rastgele atanabilir. Swagger veya tarayıcıdan öğrenebilirsin.

---

## 📅 1. Sipariş Ekle (Yeni Sipariş)

**POST** `/api/orders`

### ✍️ Gövde (JSON):
```json
{
  "userId": 1,
  "orderItems": [
    {
      "productId": 1,
      "quantity": 2
    },
    {
      "productId": 2,
      "quantity": 1
    }
  ]
}
```

### ✅ Yanıt (200 OK):
```json
{
  "id": 3,
  "orderDate": "2025-04-01T14:23:11.124Z",
  "userId": 1,
  "orderItems": [
    { "productId": 1, "quantity": 2 },
    { "productId": 2, "quantity": 1 }
  ]
}
```

### ⚠️ Hata (400 Bad Request - Stok Yoksa):
```json
"Stokta yeterli ürün yok."
```

---

## 📆 2. Tüm Siparişleri Listele

**GET** `/api/orders`

### ✅ Yanıt:
```json
[
  {
    "id": 1,
    "orderDate": "2025-03-31T11:00:00",
    "userId": 1,
    "orderItems": [
      { "productId": 1, "quantity": 1 }
    ]
  },
  {
    "id": 2,
    "orderDate": "2025-04-01T09:00:00",
    "userId": 2,
    "orderItems": [
      { "productId": 2, "quantity": 3 }
    ]
  }
]
```

---

## 📄 3. Belirli Kullanıcının Siparişleri

**GET** `/api/orders/user/{userId}`

### Örnek:
```
GET /api/orders/user/1
```

### ✅ Yanıt:
```json
[
  {
    "id": 1,
    "userId": 1,
    "orderDate": "2025-03-31T11:00:00",
    "orderItems": [
      { "productId": 1, "quantity": 1 }
    ]
  }
]
```

---

## 🔍 4. Sipariş Detayı Getir

**GET** `/api/orders/{id}`

### Örnek:
```
GET /api/orders/2
```

### ✅ Yanıt:
```json
{
  "id": 2,
  "orderDate": "2025-04-01T09:00:00",
  "userId": 2,
  "orderItems": [
    { "productId": 2, "quantity": 3 }
  ]
}
```

### ❌ Yanıt (404 Not Found):
```json
"Sipariş bulunamadı."
```

---

## 🔒 5. Sipariş Sil

**DELETE** `/api/orders/{id}`

### Örnek:
```
DELETE /api/orders/1
```

### ✅ Yanıt:
```
204 No Content
```

### ❌ Yanıt:
```
404 Not Found
```

---

## 🌐 Ek: Ürün API'leri (Opsiyonel)

### ➕ Ürün Ekle
**POST** `/api/products`
```json
{
  "name": "Laptop",
  "price": 30000,
  "stock": 15
}
```

### 📄 Ürünleri Listele
**GET** `/api/products`

---


