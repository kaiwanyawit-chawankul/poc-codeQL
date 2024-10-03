using System;
using System.Collections.Generic;

public class HighCouplingExample
{
    private readonly DatabaseService _databaseService;
    private readonly EmailService _emailService;
    private readonly LoggingService _loggingService;
    private readonly NotificationService _notificationService;
    private readonly UserService _userService;
    private readonly PaymentService _paymentService;
    private readonly ReportService _reportService;
    private readonly AnalyticsService _analyticsService;
    private readonly NotificationHandler _notificationHandler;
    private readonly CacheService _cacheService;
    private readonly ThirdPartyService _thirdPartyService;

    public HighCouplingExample(DatabaseService databaseService,
                                EmailService emailService,
                                LoggingService loggingService,
                                NotificationService notificationService,
                                UserService userService,
                                PaymentService paymentService,
                                ReportService reportService,
                                AnalyticsService analyticsService,
                                NotificationHandler notificationHandler,
                                CacheService cacheService,
                                ThirdPartyService thirdPartyService)
    {
        _databaseService = databaseService;
        _emailService = emailService;
        _loggingService = loggingService;
        _notificationService = notificationService;
        _userService = userService;
        _paymentService = paymentService;
        _reportService = reportService;
        _analyticsService = analyticsService;
        _notificationHandler = notificationHandler;
        _cacheService = cacheService;
        _thirdPartyService = thirdPartyService;
    }

    public void ProcessUser(int userId)
    {
        var user = _userService.GetUserById(userId);
        if (user == null)
        {
            _loggingService.Log("User not found.");
            return;
        }

        // Example of using multiple services
        _emailService.SendWelcomeEmail(user.Email);
        _notificationService.SendNotification(userId, "Welcome!");
        _paymentService.ProcessPayment(userId, 100);
        _reportService.GenerateUserReport(userId);
        _analyticsService.TrackUserActivity(userId);
        _notificationHandler.HandleNotifications(userId);
        _cacheService.CacheUserData(user);
        _thirdPartyService.SendUserData(user);
    }
}

// Sample service classes (for demonstration purposes)
public class DatabaseService { }
public class EmailService { public void SendWelcomeEmail(string email) { } }
public class LoggingService { public void Log(string message) { } }
public class NotificationService { public void SendNotification(int userId, string message) { } }
public class UserService { public User GetUserById(int userId) => new User(); }
public class PaymentService { public void ProcessPayment(int userId, decimal amount) { } }
public class ReportService { public void GenerateUserReport(int userId) { } }
public class AnalyticsService { public void TrackUserActivity(int userId) { } }
public class NotificationHandler { public void HandleNotifications(int userId) { } }
public class CacheService { public void CacheUserData(User user) { } }
public class ThirdPartyService { public void SendUserData(User user) { } }
public class User { public string Email => "user@example.com"; }
