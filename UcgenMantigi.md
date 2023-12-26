# Kurallar

Burada bir üçgenin çizilmesi için gerekli kurallar bulunur.

Bir üçgen çizilmesi için en az iki satıra ihtiyaç vardır. İlk satır üçgenin tepesi ikincisi ise tabanıdır. Tepe ve taban tek satırda olduğunda. Ortaya istenilen şekil çıkmaz.

```
1. /_\

2. /\
  /__\
```

## Tepe
Tepe istenilen satır sayısının 1 eksiği kadar boşluk bırakıldıktan sonra çizilir. (Üçgenin satır sayısı - 1 boşluk = tepenin yerleştirileceği yer)

**örn:** 2 satırlık üçgen istenmişse 1 boşluktan sonra tepe yerleştirilir. (2 - 1 = 1)

Satır başından sonra bir boşluk olmalı. Burada fark edilmesi için boşluk yerine 1 rakamı yerleştirilmiştir.

```
1/\     
/__\
```

## Sol Kenar
Üçgenin sol çizgisi yerleştirilirken tepe için bırakılan boşluklar her yeni satırda 1 eksilir ve tabanda satır başından sonra boşluk gelmez.

**örn:** Aşağıda 5 satırlık bir üçgen var. Tepe noktası 4 (5 - 1) boşluktan sonra geliyor ve her satırda sol taraftaki boşluk sayısı 1 azalıyor. Böylece bir sol çizgi üstündekiyle bağlantılı oluyor.

İlk satırda rakamlarla gerekli boşluk sayısı gösterildi.

```
1234/\       // 5 - 1 = 4 boşluk gerekli
   /  \      // 4 - 1 = 3
  /    \     // 3 - 1 = 2
 /      \    // 2 - 1 = 1
/________\   // 1 - 1 = 0
```

## Sağ Kenar
İlk satırda tepe olduğu için sağ ve sol çizgiler arasında boşluk yoktur. Ancak her yeni satırda 2 boşluk eklenerek bir sağ çizgi üstündeki çizgiye bağlanır.

```
    /\       // 0
   /12\      // 2 (Rakamlarla gerekli boşluk sayısı gösterildi.)
  /    \     // 4
 /      \    // 6
/________\   // 8
```