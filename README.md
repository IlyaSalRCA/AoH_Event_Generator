[:ru:](https://github.com/IlyaSalRCA/AoH_Event_Generator?tab=readme-ov-file#ru--%D0%B3%D0%B5%D0%BD%D0%B5%D1%80%D0%B0%D1%82%D0%BE%D1%80-%D1%81%D0%BE%D0%B1%D1%8B%D1%82%D0%B8%D0%B9-%D0%B4%D0%BB%D1%8F-age-of-history-3)[:us:](https://github.com/IlyaSalRCA/AoH_Event_Generator?tab=readme-ov-file#us--event-generator-for-age-of-history-3)[:cn:](https://github.com/IlyaSalRCA/AoH_Event_Generator?tab=readme-ov-file#cn-age-of-history-3-%E4%BA%8B%E4%BB%B6%E7%94%9F%E6%88%90%E5%99%A8)[:tr:](https://github.com/IlyaSalRCA/AoH_Event_Generator?tab=readme-ov-file#tr-age-of-history-3-olay-%C3%BCreticisi)

<a href="https://github.com/IlyaSalRCA/AoH_Event_Generator/releases/download/v1.2.4/EventGenerator_Setup.exe">
  <img src="https://img.shields.io/badge/Download-EventGenerator_Setup.exe-green?style=for-the-badge&logo=windows"/>
</a>

[![Downloads aoh3](https://img.shields.io/github/downloads/IlyaSalRCA/AoH_Event_Generator/v1.2.4/total?label=Downloads)](https://github.com/IlyaSalRCA/AoH_Event_Generator/releases/download/v1.2.4/EventGenerator_Setup.exe)
![r](https://img.shields.io/github/v/release/IlyaSalRCA/AoH_Event_Generator)
![l](https://img.shields.io/github/license/IlyaSalRCA/AoH_Event_Generator)

# :ru:  Генератор событий для Age of History 3!

Добро пожаловать в простой и удобный генератор событий для игры **Age of History 3**! Этот инструмент поможет вам создавать и настраивать события для вашей игры, а также переводить их на любой язык.

---

##  Возможности генератора

- **Выбор из полного списка триггеров** с подсказками по форматированию;
- **Выбор из полного списка исходов** с подсказками по форматированию;
- **Автоматическое распределение событий** по категориям: глобальные, обычные и осадные события;
- **Поддержка перевода** генератора на другие языки;
- **Локализация событий** на любой язык.

---

##  Как создать событие?

1. **Вкладка "Заголовок":**
   - Выберите тип события (обычное, глобальное, осадное);
   - Заполните поля: ID события, заголовок, описание и другие параметры;
   - Укажите дополнительные параметры (например, Pop Up).

2. **Вкладка "Триггеры":**
   - Добавьте триггер;
   - Выберите логическую переменную (И, ИЛИ, И НЕ, ИЛИ НЕ);
   - Добавьте суб-триггер;
   - Укажите логическую переменную для суб-триггера, выберите тип триггера и параметры.

3. **Вкладка "Исходы":**
   - Добавьте исход;
   - Назовите кнопку исхода и задайте шанс выбора ИИ;
   - Добавьте суб-исход;
   - Выберите тип исхода и укажите параметры.

4. **Создайте событие!**

---

##  Как перевести событие?

1. Заполните поля **Заголовок** и **Описание** на вкладке "Заголовок";
2. Добавьте нужные исходы и назовите кнопки;
3. Перейдите на вкладку **Превью**;
4. Введите текст в поля заголовка, описания и кнопок (в них отображаются подсказки с названиями);
5. Выберите язык перевода в поле **Bundle_** (*оставьте пустым для перевода на английский**, или **вписать, например, `ru`**);
6. **Создайте перевод** для события!

---

##  Как перевести сам генератор?

1. Перейдите в папку **languages**;
2. Создайте файл **.json** с инициалами нужного языка (например, `RU.json`);
3. Заполните файл по примеру других переводов;
4. Добавьте инициалы созданного файла в файл **languages.txt** на новой строке;
5. В папке **trigger_outcomes** создайте папку с инициалами языка (например, `RU`);
6. Добавьте файлы **outcomes_desc.txt** (168 строк) и **triggers_desc.txt** (229 строк) с переводом;
7. **Вы великолепны!** 

---

# :us:  Event Generator for Age of History 3! 

Welcome to the easy-to-use **Event Generator** for **Age of History 3**! This tool will help you create and customize events for your game, as well as translate them into any language.

---

##  Generator Features

- **Choose from a full list of triggers** with formatting tips;
- **Choose from a full list of outcomes** with formatting tips;
- **Automatic event categorization**: global, regular, and siege events;
- **Support for translating** the generator into other languages;
- **Localization of events** into any language.

---

##  How to Create an Event?

1. **Title Tab:**
   - Select the event type (regular, global, siege);
   - Fill in the fields: Event ID, Title, Description, and other parameters;
   - Specify additional parameters (e.g., Pop Up).

2. **Triggers Tab:**
   - Add a trigger;
   - Select a logical variable (AND, OR, AND NOT, OR NOT);
   - Add a sub-trigger;
   - Specify the logical variable for the sub-trigger, choose the trigger type, and set parameters.

3. **Outcomes Tab:**
   - Add an outcome;
   - Name the outcome button and set the AI selection chance;
   - Add a sub-outcome;
   - Choose the outcome type and set parameters.

4. **Create the event!**

---

##  How to Translate an Event?

1. Fill in the **Title** and **Description** fields on the "Title" tab;
2. Add the desired outcomes and name the buttons;
3. Go to the **Preview** tab;
4. Enter the text in the title, description, and button fields (they contain watermarks with hints);
5. Select the translation language in the **Bundle_** field (leave it *blank for English**, or **write for example `ru`**);
6. **Create a translation** for the event!

---

##  How to Translate the Generator?

1. Go to the **languages** folder;
2. Create a **.json** file with the initials of the desired language (e.g., `EN.json`);
3. Fill in the file following the example of other translations;
4. Add the initials of the created file to the **languages.txt** file on a new line;
5. In the **trigger_outcomes** folder, create a folder with the language initials (e.g., `EN`);
6. Add the files **outcomes_desc.txt** (168 lines) and **triggers_desc.txt** (229 lines) with the translation;
7. **You are awesome!** 

---

# :cn: Age of History 3 事件生成器！

欢迎使用这款简单便捷的 **Age of History 3** 事件生成工具！它能帮助你为游戏创建和自定义事件，并支持翻译成任意语言。

---

## 生成器功能

- **从完整触发器列表中选择**，附带格式提示；
- **从完整结果列表中选择**，附带格式提示；
- **自动将事件分类**：全局事件、普通事件和围城事件；
- **支持多语言翻译** 生成器界面；
- **本地化事件内容** 至任意语言。

---

## 如何创建事件？

1. **“标题”选项卡：**
   - 选择事件类型（普通、全局、围城）；
   - 填写字段：事件ID、标题、描述等参数；
   - 设置附加选项（如Pop Up弹窗）。

2. **“触发器”选项卡：**
   - 添加触发器；
   - 选择逻辑变量（AND, OR, AND NOT, OR NOT）；
   - 添加子触发器；
   - 为子触发器设置逻辑变量，选择触发器类型及参数。

3. **“结果”选项卡：**
   - 添加结果；
   - 命名结果按钮并设置AI选择概率；
   - 添加子结果；
   - 选择结果类型并填写参数。

4. **生成事件！**

---

## 如何翻译事件？

1. 在“标题”选项卡填写**标题**和**描述**；
2. 添加结果并命名按钮；
3. 切换到**预览**选项卡；
4. 在标题、描述和按钮字段中输入翻译文本（字段会显示提示名称）；
5. 在 **Bundle_** 字段选择目标语言（*留空则默认翻译为英语**，或输入语言代码如 `ru`**）；
6. **生成翻译版**事件！

---

## 如何翻译生成器界面？

1. 进入 **languages** 文件夹；
2. 创建语言代码命名的 **.json** 文件（如 `RU.json`）；
3. 参照其他翻译文件填写内容；
4. 在 **languages.txt** 中新增一行添加该语言代码；
5. 在 **trigger_outcomes** 文件夹内创建语言代码子文件夹（如 `RU`）；
6. 添加翻译文件 **outcomes_desc.txt**（168行）和 **triggers_desc.txt**（229行）；
7. **您做得太棒了！** 

---

# :tr: Age of History 3 Olay Üreticisi!

**Age of History 3** için basit ve kullanıcı dostu bu olay üreticisine hoş geldiniz! Bu araç, oyununuz için özel olaylar oluşturmanıza, düzenlemenize ve bunları istediğiniz dile çevirmenize yardımcı olacaktır.

---

## Üretici Özellikleri

- **Tam tetikleyici listesinden seçim** (biçimlendirme ipuçlarıyla birlikte);
- **Tam sonuç listesinden seçim** (biçimlendirme ipuçlarıyla birlikte);
- **Olayların otomatik sınıflandırılması**: küresel olaylar, normal olaylar ve kuşatma olayları;
- **Çoklu dil desteği** (arayüz çevirisi);
- **Olayların lokalizasyonu** (istediğiniz dile çevirme).

---

## Olay Nasıl Oluşturulur?

1. **"Başlık" Sekmesi:**
   - Olay türünü seçin (normal, küresel, kuşatma);
   - Olay ID, başlık, açıklama ve diğer parametreleri doldurun;
   - Ek seçenekleri belirtin (örneğin, Pop Up).

2. **"Tetikleyiciler" Sekmesi:**
   - Tetikleyici ekleyin;
   - Mantıksal operatör seçin (VE, VEYA, VE DEĞİL, VEYA DEĞİL);
   - Alt tetikleyici ekleyin;
   - Alt tetikleyici için parametreleri girin.

3. **"Sonuçlar" Sekmesi:**
   - Sonuç ekleyin;
   - Buton adını ve AI seçim şansını ayarlayın;
   - Alt sonuç ekleyin;
   - Sonuç türünü seçin ve parametreleri girin.

4. **Olayı oluşturun!**

---

## Olay Nasıl Çevrilir?

1. **"Başlık" sekmesinde** başlık ve açıklamayı doldurun;
2. Gerekli sonuçları ekleyin ve butonları adlandırın;
3. **"Önizleme" sekmesine** geçin;
4. Başlık, açıklama ve buton metinlerini girin (ipuçları görüntülenecektir);
5. **Bundle_** alanında hedef dili seçin (*boş bırakırsanız İngilizce olur**, veya `ru` gibi dil kodunu girin**);
6. Çevrilmiş olayı **oluşturun**!

---

## Üretici Arayüzü Nasıl Çevrilir?

1. **languages** klasörüne gidin;
2. Dil koduyla bir **.json** dosyası oluşturun (örneğin `TR.json`);
3. Diğer çeviri dosyalarını örnek alarak içeriği doldurun;
4. **languages.txt** dosyasına yeni bir satırda dil kodunu ekleyin;
5. **trigger_outcomes** klasöründe dil koduyla bir alt klasör oluşturun (örneğin `TR`);
6. **outcomes_desc.txt** (168 satır) ve **triggers_desc.txt** (229 satır) dosyalarını çeviriyle ekleyin;
7. **Harikasınız!** 

---

Спасибо за использование нашего генератора! Если у вас есть вопросы или предложения, создайте **issue** или свяжитесь с нами.  
Thank you for using our generator! If you have any questions or suggestions, please create an **issue** or contact us.
