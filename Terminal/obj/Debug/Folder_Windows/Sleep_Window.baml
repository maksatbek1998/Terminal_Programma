   M S B A M L   `   `   `  ����C  ?Terminal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:Terminal.Folder_WindowsTerminal.Folder_Windows  5   	   *    $Terminal.Folder_Windows.Sleep_Window   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7local%clr-namespace:Terminal.Folder_Windows     5   	   -   5          � Title$  Sleep_Window��5   	   $	��200��6   $	��400��6+   
������� J� Opacity$	 0.9Q�5	       � WindowStyle$
 None=�5
   	    � WindowStartupLocation$ CenterScreen=�6    � AllowsTransparency . .��5      �  � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��80 �6   .+�5   
   � $��0��6   .+�5      �� -   5         ��Name$ canvas��5      $	��115��6%   $	��115��61   $��Center=�6>   $��Center=�6[    J� RenderTransformOrigin$ 0.5,0.5&�6v   z�5      V� 5      .~�5      �� �� 5      �� 5      T� 5      5       � Triggers 5      :� 5      	 :� RoutedEvent$	 Loaded��6#   .[�5      �� .��5      �� .��5   "   U� 
 �� TargetProperty$V
 P(UIElement.RenderTransform).(TransformGroup.Children)[2].(RotateTransform.Angle)�6@    �� 
TargetName$ canvas��6�    g� RepeatBehavior$ Forever��6�   .\�5   &   9  3System.Windows.Media.Animation.EasingDoubleKeyFrame   O� KeyTime$ 0��6;    O� Value$ 0Q�6G     5    &   $ 0:0:2��6;   $	 360Q�6K   5!   #   5"      5#      5$      .+�5&      A� ���	#FF01AC9E$��20��6+    �� Left$
 46.5��67   $��20��6J   
 �� Top$ 83��6U   A� 5'      ���	#FF01AC9E$��20��6+   $
 80.5��67   $��20��6J   $ 49��6U   $	 0.6Q�6e   A� 5(      ���	#FF01AC9E$��20��6+   $
 46.5��67   $��20��6J   $ 17��6U   $	 0.4Q�6e   A� 5)      ���	#FF01AC9E$��20��6+   $
 14.5��67   $��20��6J   $ 49��6U   $	 0.2Q�6e   A� 5*      ���	#FF01AC9E$��20��6+   $
 23.5��67   $��20��6J   $ 72��6U   $	 0.1Q�6e   A� 5+      ���	#FF01AC9E$��20��6+   $
 70.5��67   $��20��6J   $ 73��6U   $	 0.8Q�6e   A� 5,      ���	#FF01AC9E$��20��6+   $
 69.5��67   $��20��6J   $ 26��6U   $	 0.5Q�6e   A� 5-      ���	#FF01AC9E$��20��6+   $
 23.5��67   $��20��6J   $ 27��6U   $	 0.3Q�6e   5/      50      � 51   
   $��1��6   .+�52      �� $��Подождите !!!��6   $��30(�6-   $	��Top=�6;   $��Center=�6S   ���	#FF01AC9E6p   53      54      55      