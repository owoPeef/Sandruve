# Sandruve
Программа была создана для общения на основе передаче данных по TCP-Socket'ам.
Для создания сервера, клиентов, принятие и отправку пакетов отвечает TCP пакет, — SimpleTCP ([NuGet](https://www.nuget.org/packages/SimpleTCP/1.0.24)).
Чтобы начать пользоваться программой необходимо просто её запустить. Если у вас установлена не последняя версия программы, то она сама обновиться до новой версии (*при наличии подключения к сети*).
За обновление отвечает [Sandruve/Updater](https://github.com/owoPeef/Sandruve/tree/master/Updater).


## Описание работы Updater'а
Если программа обнаружила, что вышел новый релиз на *Github*, она закрывает процесс и открывает `файл Updater.exe` (сам файл, отвечающий за *Обновление*) с аргументом `--ver{latest_github_version}`, `Updater` - отдельное решение, переделанное в это для удобства.
`Updater` запускает таймер, который считает за сколько *МС* программа закончит установку обновления, и в конце консоли выведет значение.
Дальше идёт цикл, который проверяет аргументы (аргументы, вызванные при запуске самого `Updater`'а).
Если `Updater` был запущен без аргументов, программа выдаст ошибку, так как не сможет получить версию с аргумента.
Если же программа запущена корректно, с аргументами, то начнётся установка новой версии.
Последовательность действий установки:
1. Программа получает файл с сервера, и сохраняет в текущую использованную папку как `temp.zip`;
2. После получения файла с сервера, идёт удаление файлов программы прошлой версии;
3. Когда все файлы прошлой версии программы удалены, файл `temp.zip` начинает разархивироваться в текущую использованную папку;
4. После данного процесса, все временные файлы (т.е. `temp.zip`) удаляются;
5. Выводится время в *МС*, за которое программа завершила установку.


Но помните, **ПРОГРАММА НАХОДИТСЯ В РАЗРАБОТКЕ, В НЕЙ МОГУТ БЫТЬ УЯЗВИМОСТИ И БАГИ**.
Если вы нашли баг, то пожалуйста, помогите проекту, и сообщите о баге [здесь](https://github.com/owoPeef/Sandruve/issues).