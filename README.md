
## İlkbyte Dotnet Kütüphanesi  

#### Özet;

Aşağıda firmanın kendi servis dökümanını bulabilirsiniz. Bu kütüphane .Net 7.0 ile oluşturulmuştur. Amacı tamamen kullanımı kolaylaştırmak içindir. 

```
https://apidocs.ilkbyte.com/docs/1.0/overview
```
#### Register işlemi için;

Oluşturulan Api dosyasının Program.cs dosyası içerisine aşağıdaki Register methodu'nun eklenmesi gerekmektedir.

```
using IlkByteDotnet;

var configuration = builder.Configuration;

builder.Services.RegisterIlkByte(configuration);
```
#### appsettings dosyası için;
```
"Ilkbyte": {
  "Access": "access-key",
  "Secret": "secret-key"
}
```


#### Örnek kullanım için;

```
private readonly IIlkByteService _ilkByteService;

public ByteTestController(IIlkByteService ilkByteService)
=> this._ilkByteService = ilkByteService;

** Örnek method

[HttpGet]
public async Task<BaseModel<Account>> Account()
 => await _ilkByteService.Account();

```
