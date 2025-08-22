using SendNotificationTDSPJ.Application.DTOS.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SendNotificationTDSPJ.Application.UseCases;

public interface INotificationUseCase
{
    void Send(NotificationRequest notificationRequest);
}
