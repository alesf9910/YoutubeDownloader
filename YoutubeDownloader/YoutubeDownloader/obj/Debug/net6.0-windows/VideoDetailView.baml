   M S B A M L   `   `   `  ????L  HYoutubeDownloader, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:YoutubeDownloaderYoutubeDownloader  5      '    !YoutubeDownloader.VideoDetailView   5   
   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      _ [MaterialDesignThemes.Wpf, Version=4.7.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962a:md1http://materialdesigninxaml.net/winfx/xaml/themes  5      +localclr-namespace:YoutubeDownloader  5         MaterialDesignBackground#??[  5	   "   #  MaterialDesignThemes.Wpf.Card    UniformCornerRadius$  15Q?6Z   $??0 0 0 10q?6s   .  (MaterialDesignThemes.Wpf.ElevationAssist   	Elevation$	 Dp1=?6?   $	??100??6?   .??5
      ? $??2q?6    ? ColumnDefinitions 5   
   ?? 5      $	??100 ?6   ?? 5      $
??300* ?6   ?? 5      $??50 ?6   .+?5   
   ?? -   5         ??Name$ videoImg??5      $??0??6"   $??5q?62   $??UniformToFill=?6=   5      ?? 5   
   $??1??6   $??5q?6%    ?? Orientation$ Vertical=?60   .+?5      ?? -   5         ??Name$ 
videoTitle??5      $
??Bold"?6H   $
??Wrap=?6Z   ??6,   ??  ?? Path$ Title?6p   ?? 5      -   5        $ videoResumen??5       J? Opacity$	 0.8Q?6P   $
??Wrap=?6^   ??6.   ?? $ Description?6t   5      ?? 5   
   $??2??6   $ Vertical=?6%   $??7q?6<   .+?5      ?? $??35??6   $??35??6    $??0q?6,   
???????$??0q?6K   .??5      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$
 Play=?6   
???   ?6?   5      ?? 5      $??35??6   $??35??6    $??0q?6,   $??0 12 0 0q?68   
???????$??0q?6]   .??5        $ Download=?6   
???   ?6C   5      5      5      5      