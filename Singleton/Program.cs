using Singleton;

Logger logger1 = Logger.CreateInstance();
logger1.WriteLog("Sample log1");

Logger logger2 = Logger.CreateInstance();
logger2.WriteLog("Sample log2");