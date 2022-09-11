namespace test_event.Models;

public class ForgetPasswordCode
{
    public Guid Id { get; set; }

    public string Code { get; set; } = string.Empty;


    public int ExpiredTime { get; set; }

    public DateTimeOffset CreatedAt { get; set; } = DateTimeOffset.UtcNow;
}