namespace Emes.Application.Service;

public sealed class NoticeService : INoticeService, ITransient
{
    public NoticeService()
    {

    }

    public Task HandleAsync(ApiData data)
    {
        return Task.CompletedTask;
    }
}
