using DesignPattern.Builder;

ConnectionStringBuilder cb = new("\\SqlServer");

cb.AddUsernameAndPassword("shuva", "123456");