   M S B A M L   `   `   `  ����O  KNotifications_Window, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:Notifications_WindowNotifications_Window  5   	   %    Notifications_Window.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:Notifications_Window     5   	   -   5          � Title$  
MainWindow��5   	   $	��270��6    � 
ResizeMode$ NoResize=�6)   $	��450��6?    � WindowStyle$
 None=�6K    � Icon$ Image/Png_Ico.png��6^    � AllowsTransparency .  � Topmost . ��6�   Z� .��5	      � -   5        
�������$��	10,10,5,5q�5	   M    � RowDefinitions 5
   
   �� 5      $��40 �6   �� 5      �� 5      $��60 �6    J� Effect 5   
   3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 10Q�6   	   	Direction$		 280Q�6/   
   Opacity$
 1Q�6?      ShadowDepth$ 2Q�6K   .+�5   
   ��  �� Orientation$ 
Horizontal=�6   $	��430��6.   .+�5      �� $	��350��6   .+�5      �� -   5         ��Name$ userText��5      $��5,10,0,0q�6.   ���#01B3A4$��15(�5      $��24��6*   !Имя пользователя5      5      �� 5   
   $ 
Horizontal=�6   $	��Top=�6.   $��Right=�6F   $��0��6b   .+�5      �� -   5           Button_Remov_Row#���   5      $��	0,0,0,-12q�6@   .��5      �� $��Image/Minus.png��6   5      �� 5      -   5        #���   5      .��5       �� $��Image/Close1.png��6   5!      5"      5#      � 5$   
   $��1��6   .+�5%      �� -   5        $ Label��5%      $�� ��6'   $	��100(�6/   $��Center=�6>   $��Center=�6Y   ���#01B3A4$
��Bold"�6�   $��	0,-15,0,0q�6�   5&      � 5'   
   $��2��6   .+�5(      �� $ 
Horizontal=�6   $��Center=�62   $��Center=�6M   .+�5)      d� -   5         d�Name$
 Next��5)      $	��200��6-   $��5q�69   $��40��6D   $��Следующий��6P     Togle_Button#���  6d   6�   �� 5*      -   5         ��Name$ zvonok��5*        Menu_Button#���  6)   $��40��6O   $	��200��6[   .��5+      �� $ 
Horizontal=�6!   .+�5,      �� $��Image/pozvat.png��6    $��
-20,0,15,0q�6:   �� 5-      $��Позвать��6$   $��Center=�63   $��20(�6N   5.      5/      50      51      52      53      