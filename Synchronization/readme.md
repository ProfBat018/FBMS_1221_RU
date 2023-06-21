# Тема урока.
* Синхронизация потоков.
* Модуль threading

### Синхронизация - это согласование действий потоков, чтобы они не мешали друг другу.

В программировании есть такой термин, как Thread Block, Thread Race, Thread Deadlock. Это ситуации, когда потоки не синхронизированы и мешают друг другу.


## Приведем пример:

Уже 10.15, я выпустил вас на перемену, Эмиль и Мага 
так спешили выйти вместе, что застряли в дверях.
Их движение заблокировало дверь, и никто не может пройти.
Это и есть ***Thread Block.***

Если Мага купил Didme сендвич, и взял к нему кетчуп,
при этом кетчуп нужен и Эмилю. 
Тут проблема в том, что Мага использует весь кетчуп,
и Эмилю не хватит. 
Это проблема синхронизации.

Дальше примеры смотрите в коде.

# Какие бывают синхронизации ?
* lock(сахар над классом Monitor, потому что никому
не нравится писать try finally и Monitor.Enter и Exit)
* Monitor - самый низкоуровневый класс синхронизации
Работает только с потоками текущего процесса.
* Mutex - высокоуровневый класс синхронизации.
Он работает с потоками всех процессов.
* Semaphore - высокоуровневый класс синхронизации. 
Он работает с потоками всех процессов.
* SemaphoreSlim - высокоуровневый класс синхронизации.
Он работает только с потоками текущего процесса.

Strictly speaking, a mutex is a locking mechanism used to synchronize access to a resource. Only one task (can be a thread or process based on OS abstraction) can acquire the mutex. It means there will be ownership associated with mutex, and only the owner can release the lock (mutex).

Semaphore is signaling mechanism (“I am done, you can carry on” kind of signal). For example, if you are listening songs (assume it as one task) on your mobile and at the same time your friend called you, an interrupt will be triggered upon which an interrupt service routine (ISR) will signal the call processing task to wakeup.

  
![img.png](..%2F..%2FFBAS_4217_RU%2FProjects%2FRepeat%2Fimg.png)

## Mutex vs Semaphore

Mutex работает через OS. 
Semaphore работает через CLR.
Monitor работает через CLR.

# Mutex

У mutex есть имя, и он может быть глобальным.
При создании мы задаем параметры:
* InitialOwned - владеет ли мьютекс потоком, который его создал
* Boolean - создавать новый мьютекс или открывать существующий.
* Name - имя мьютекса.

Где понадобится Semaphore, где можно использовать 2 и более потоков. 

В случае с веб-приложением, если мы хотим, чтобы одновременно обрабатывалось 10 запросов, 
то мы можем создать Semaphore с 10 слотами. 
И если все слоты заняты, то новые запросы будут ждать, пока не освободится слот.

### Спойлеры к следующему уроку:
* Класс ThreadPool
* Работа ThreadPool


