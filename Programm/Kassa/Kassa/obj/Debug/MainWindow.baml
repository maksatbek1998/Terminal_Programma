   M S B A M L   `   `   `  ����@  <Kassa, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:KassaKassa  5   	       Kassa.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:Kassa     5   	   -   5          � Title$  
MainWindow��5   	   $	��320��6    � 
ResizeMode$ NoResize=�6)   $	��350��6?    � WindowStyle$
 None=�6K    � Icon$ Image/Png_Ico.png��6^    � AllowsTransparency .  � Topmost . ��6�   Z� .��5	      � -   5        
�������$��	10,10,5,5q�5
   :    J� Effect 5   
   3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 10Q�6      	Direction$	 280Q�6/   	   Opacity$	 1Q�6?   
   ShadowDepth$
 2Q�6K    � RowDefinitions 5   
   �� 5      $��40 �6   �� 5      $	��160 �6   �� 5      $	��125 �6   .+�5   
   ��  �� Orientation$ 
Horizontal=�6   $	��330��6.   .+�5      �� $	��250��6   .+�5      �� -   5         ��Name$ userText��5      $��5,10,0,0q�6.   ���#01B3A4$��15(�5      $��24��6*   !Имя пользователя5      5      �� 5      $ 
Horizontal=�6   $	��Top=�5      $��Right=�6-   $��0��6I   .+�5       �� -   5           Button_Remov_Row#���   5       $��	0,0,0,-12q�6D   .��5!      �� $��Image/Minus.png��6   5"      �� 5#      -   5        #���   5#      .��5$      �� $��Image/Close1.png��6   5%      5&      5(      � 5)   
   $��1��6   .+�5*      �� -   5        $ Label��5*      $�� ��6'   $	��100(�6/   $��Center=�6>   $��Center=�6Y   $
��Bold"�6v   ���#01B3A46�   5+      � 5,   
   $��2��6   .+�5-      �� .+�5.      �� $ 
Horizontal=�6   $��Center=�66   .+�5/      �� -   5         ��Name$ btn_1��5/        Menu_Button#���  6,   $��30��6R   $	��145��6^   $��5,0,5,10q�6j   $��
Далее��6|   6�   �� 50      -   5        $ btn_2��50      #���  6,   $��30��6R   $	��145��6^   $��3,0,5,10q�6j   .��51      �� $ 
Horizontal=�6%   .+�52      �� $��Image/pozvat.png��6$   $��
-20,0,15,0q�6>   �� 53      $��Позвать��6(   $��Center=�67   $��18(�6R   54      55      57      �� 58      $��0,10,0,0q�6   .+�59      �� -	   5        $ btn_3��59      #���  6,   $��40��6R   $	��250��6^   $��Удаление очер��5:      66   5;      5<      5=      5>      5?      