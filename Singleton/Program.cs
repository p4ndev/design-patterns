using SingletonPattern;

Logger _logger = Singleton.Instance;

_logger.Log($"Logging started at {DateTime.Now}");

_logger.Log("Hello World!!!");

_logger.Log($"Logging ended at {DateTime.Now}");

_logger.Done();