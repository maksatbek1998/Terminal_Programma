   M S B A M L   `   `   `  ����C  ?Terminal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:TerminalTerminal  5   	   9!clr-namespace:Terminal.ViewModelsTerminal.ViewModels  5   	       Terminal.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:Terminal     5   	   0vm!clr-namespace:Terminal.ViewModels     5   	     � Title$  
MainWindow��5	   	   $	��800��6   $
��1200��6)    � WindowState$ 	Maximized=�66    � WindowStyle$
 None=�6N    � WindowStartupLocation$ CenterScreen=�6a    � DataContext 5
      (  "Terminal.ViewModels.ViewModelClass  5   
   .��5      � 
�������.+�5   
   ��  �� Orientation$ 
Horizontal=�6   $	��Top=�6.   $
��Left=�6F   .+�5   
   �� $��Image/Icon/Medic.png��6   $	��100��5      $	��130��6   $��5,5,0,0q�6)   �� 5      $��60(�6   $��
-20,15,0,0q�6&   ���#00C8B8
ОМДКБ6V   5      � 5   
   $	��150��6   $	��300��6   $	��Top=�6(   $��Right=�6@   .+�5      �� $��Center=�6   $��0,10,0,0q�66   $	��300��6H   $	��155��6T   .+�5      �� -   5         ��Name$
 Data��5      $��00:00:00��6*   $��35(�6:   ���	#FF01AC9E6H   �� 5      -   5        $ Hours��5      $��00:00��6+   $��30(�68   ���	#FF01AC9E6G   5      � 5      
�������$��25��6&   $��Center=�62   $��Center=�6M   $��7��6j   $��-230,13,0,0q�6t   .+�5      �� -   5        $ Metka��5      $��:��6+   $��30(�64   ���	#FF01AC9E$��	0,-13,0,0q�6Z   5      5      �� 5   
   $��Center=�6   $��0,0,0,0q�60   .+�5      �� -   5           Menu_Button#���   5      ��6;   �� *Appointment+6[   �� 5      -   5         ��Name$ kassa��5      #���   6$   ��5       �� *	Cashier+61   �� 5!      -   5        $ Lab_A��5!      #���   6$   ��5"      �� *
Laboratory+64   �� 5#      -   5        $ Lab_B��5#      #���   6$   ��6J   �� *LabB+6c   5$      � 5%   
   $	��150��6   $	��360��6   $��Bottom=�6(   $��Right=�6C   $��20q�6_   .+�5&      �� $��Center=�6   $��0,10,0,0q�66   $ 
Horizontal=�6H   .+�5'      ��   	Round_KGZ#���  6   ��6=   �� *ToKG+�� 5(        	Round_Rus#���  6   ��6=   �� *ToRU+�� 5)        	Round_Eng#���  6   ��6=   �� *ToEN+5+      5,      5-      5.      