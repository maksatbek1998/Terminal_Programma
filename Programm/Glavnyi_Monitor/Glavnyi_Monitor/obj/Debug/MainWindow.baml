   M S B A M L   `   `   `  ����J  FGlavnyi_Monitor, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Glavnyi_MonitorGlavnyi_Monitor  5   	        Glavnyi_Monitor.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:Glavnyi_Monitor     5   	   -   5          � Title$  
MainWindow��5   	   $	��700��6   $
��1200��6)    � WindowStyle$
 None=�66    � 
ResizeMode$ NoResize=�6I    � WindowState$ 	Maximized=�6_    � 	Resources 5	         Kalomka_Animation g� FillBehavior g� RepeatBehavior �� TargetProperty �� 
TargetName	 R� KeyTime  System.Windows.Visibility
   Visible R� Value  TextBloc_Animated	 �� To g� AutoReverse g� Duration �� From �� ElementName �� Path��%�  &	        &	 �    �� 5
   
   $ HoldEnd=�60   $ 00:00:24��6G   .��5      T� $ (UIElement.Visibility)�6,   $
 path��6_   ..�5      i� $	 0:0:0.4��6)   # Z
 6;   5      T� 5      $ (UIElement.Visibility)�6,   $ path1��6_   ..�5      i� $	 0:0:0.8��6)   # Z
 6;   5      T� 5      $ (UIElement.Visibility)�6,   $ path2��6_   ..�5      i� $	 0:0:1.2��6)   # Z
 6;   i� 5      $	 0:0:1.6��6)   # Z
 6;   5      5      �� 5   
   $ HoldEnd=�6/   $ 00:00:24��6F   .��5      �� $ buttonColor��6   $ Color�6A   $ #01B5A6X�5   2    . $ 0:0:0.8D�6S    5   c   �� $ buttonColor��$ Color�5   S   5      5      .��5      �  � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $	��120 �6   .+�5!   
   � -   5         �Name$	 Win��5!      $��0��6   .+�5"      �� }�. .+�5#      � z�5$      T� 5%      -   5        	translate��5%   -    � Triggers 5'      :� 5(       :� RoutedEvent$ FrameworkElement.Loaded��6'   .[�5)      �� .��5*   "   �� $ Forever��6-   .��5+   &   W� -   5         W�Name$ c1��5+   6    W� From$ 0X�5,   !   $ 	translate��5-   !   $ Y�5.   !   $ 0:0:20D�5/   !   50   #   51      52       54      �� 55      �� 56      .+�58      �� -   5         ��Name$ f1��58   .   $��0��6!   .+�59      � $	��150��6    ���	#FFECECEC$��0,5,0,0q�6D   .+�5:      ��   MenuText#���  6(   $��
25,35,0,35q�6K   №1 НЕВРОПОТОЛОГ6p   � 5;        
Grid_Style#���  6$   .+�5<   "   (�  (� Stretch$ Uniform=�6*   $	��550��6<   $	��150��6H   .��5=   &   � $��Center=�60   $	��550��6K   $
��Auto��6W   $��Stretch=�6e   .+�5>   *   �� $	��P55��61   �� 5?   *   $	��P55��61   �� 5@   *   $	��P55��61   �� 5A   *   $	��P55��61   �� 5B   *   $	��P55��61   �� 5C   *   $	��P55��61   �� 5D   *   $	��P55��61   �� 5E   *   $	��P55��61   5F   '   5G   #   5H      5I      � 5J      $	��150��6!   
�������$��0,5,0,0q�6B   .+�5K      �� #���  6(   №2 КАРДИОЛОГ6Y   � 5L      #���  6$   .+�5M   "   ��  �� Orientation$ 
Horizontal=�6-   .+�5N   &   �� $ 
Horizontal=�61   $��Center=�6K   .+�5O   *   A� $��20��62   $��20��6>   ���	#FF01B5A66J   �� 5P   *   $
��P999��64   $��60(�6@   $��Medium"�6N   
���  ��6b   5Q   '   �� 5R   &   $ 
Horizontal=�61   $��25,5,0,0q�6J   $��Center=�6\   .+�5S   *   A� $��20��62   $��20��6>   ���	#FF01B5A66I   �� 5T   *   $
��P999��64   $��60(�6@   $��Medium"�6N   
���  ��6b   5U   '   �� 5V   &   $ 
Horizontal=�61   $��25,5,0,0q�6J   $��Center=�6\   .+�5W   *   A� $��20��62   $��20��6>   ���	#FF01B5A66J   �� 5X   *   $
��P999��64   $��60(�6@   $��Medium"�6N   
���  ��6b   5Y   '   5Z   #   5[      5\      � 5]      $	��150��6    ���	#FFECECEC$��0,5,0,0q�6D   .+�5^      �� #���  6(   $��
25,35,0,35q�6K   №3 ОФТАЛМОЛОГ6n   � 5_      #���  6$   .+�5`   "   �� $ 
Horizontal=�6-   .+�5a   &   �� $ 
Horizontal=�61   $��Center=�6K   .+�5b   *   A� $��20��62   $��20��6>   ���	#FF01B5A66J   �� 5c   *   $
��P999��64   $��60(�6@   $��Medium"�6N   
���  ��6b   5d   '   �� 5e   &   $ 
Horizontal=�61   $��25,5,0,0q�6J   $��Center=�6\   .+�5f   *   A� $��20��62   $��20��6>   ���	#FF01B5A66I   �� 5g   *   $
��P999��64   $��60(�6@   $��Medium"�6N   
���  ��6b   5h   '   �� 5i   &   $ 
Horizontal=�61   $��25,5,0,0q�6J   $��Center=�6\   .+�5j   *   A� $��20��62   $��20��6>   ���	#FF01B5A66J   �� 5k   *   $
��P999��64   $��60(�6@   $��Medium"�6N   
���  ��6b   5l   '   5m   #   5n      5o      � 5p      $	��150��6!   
�������$��0,5,0,0q�6B   .+�5q      �� #���  6(   $��58(�6K   №4 ГЕПАТОЛОГ�� 6f   ГАСТРОЭНТРОЛОГ6�   � 5r      #���  6$   .+�5s   "   �� $ 
Horizontal=�6-   .+�5t   &   �� $ 
Horizontal=�61   $��Center=�6K   .+�5u   *   A� $��20��62   $��20��6>   ���	#FF01B5A66J   �� 5v   *   $
��P999��64   $��60(�6@   $��Medium"�6N   
���  ��6b   5w   '   �� 5x   &   $ 
Horizontal=�61   $��25,5,0,0q�6J   $��Center=�6\   .+�5y   *   A� $��20��62   $��20��6>   ���	#FF01B5A66I   �� 5z   *   $
��P999��64   $��60(�6@   $��Medium"�6N   
���  ��6b   5{   '   �� 5|   &   $ 
Horizontal=�61   $��25,5,0,0q�6J   $��Center=�6\   .+�5}   *   A� $��20��62   $��20��6>   ���	#FF01B5A66J   �� 5~   *   $
��P999��64   $��60(�6@   $��Medium"�6N   
���  ��6b   5   '   5�   #   5�      5�      � 5�      $	��150��6    ���	#FFECECEC$��0,5,0,0q�6D   .+�5�      �� #���  6(   $��
25,35,0,35q�6K   №5 НЕФРОЛОГ6l   � 5�      #���  6$   .+�5�   "   �� $ 
Horizontal=�6-   .+�5�   &   �� $ 
Horizontal=�61   $��Center=�6K   .+�5�   *   A� $��20��62   $��20��6>   ���	#FF01B5A66J   �� 5�   *   $
��P999��64   $��60(�6@   $��Medium"�6N   
���  ��6b   5�   '   �� 5�   &   $ 
Horizontal=�61   $��25,5,0,0q�6J   $��Center=�6\   .+�5�   *   A� $��20��62   $��20��6>   ���	#FF01B5A66I   �� 5�   *   $
��P999��64   $��60(�6@   $��Medium"�6N   
���  ��6b   5�   '   �� 5�   &   $ 
Horizontal=�61   $��25,5,0,0q�6J   $��Center=�6\   .+�5�   *   A� $��20��62   $��20��6>   ���	#FF01B5A66J   �� 5�   *   $
��P999��64   $��60(�6@   $��Medium"�6N   
���  ��6b   5�   '   5�   #   5�      5�      � 5�      $	��150��6!   
�������$��0,5,0,0q�6B   .+�5�      �� #���  6(   №6 ГЕМАТОЛОГ6Y   � 5�      #���  6$   .+�5�   "   �� $ 
Horizontal=�6-   .+�5�   &   �� $ 
Horizontal=�61   $��Center=�6K   .+�5�   *   A� $��20��62   $��20��6>   ���	#FF01B5A66J   �� 5�   *   $
��P999��64   $��60(�6@   $��Medium"�6N   
���  ��6b   5�   '   �� 5�   &   $ 
Horizontal=�61   $��25,5,0,0q�6J   $��Center=�6\   .+�5�   *   A� $��20��62   $��20��6>   ���	#FF01B5A66I   �� 5�   *   $
��P999��64   $��60(�6@   $��Medium"�6N   
���  ��6b   5�   '   �� 5�   &   $ 
Horizontal=�61   $��25,5,0,0q�6J   $��Center=�6\   .+�5�   *   A� $��20��62   $��20��6>   ���	#FF01B5A66J   �� 5�   *   $
��P999��64   $��60(�6@   $��Medium"�6N   
���  ��6b   5�   '   5�   #   5�      5�      � 5�      $	��150��6    ���	#FFECECEC$��0,5,0,0q�6D   .+�5�      �� #���  6(   $��
25,35,0,35q�6K   №7 ПЕДИАТР6k   � 5�      #���  6$   .+�5�   "   �� $ 
Horizontal=�6-   .+�5�   &   �� $ 
Horizontal=�61   $��Center=�6K   .+�5�   *   A� $��20��62   $��20��6>   ���	#FF01B5A66J   �� 5�   *   $
��P999��64   $��60(�6@   $��Medium"�6N   
���  ��6b   5�   '   �� 5�   &   $ 
Horizontal=�61   $��25,5,0,0q�6J   $��Center=�6\   .+�5�   *   A� $��20��62   $��20��6>   ���	#FF01B5A66I   �� 5�   *   $
��P999��64   $��60(�6@   $��Medium"�6N   
���  ��6b   5�   '   �� 5�   &   $ 
Horizontal=�61   $��25,5,0,0q�6J   $��Center=�6\   .+�5�   *   A� $��20��62   $��20��6>   ���	#FF01B5A66J   �� 5�   *   $
��P999��64   $��60(�6@   $��Medium"�6N   
���  ��6b   5�   '   5�   #   5�      5�      � 5�      $	��150��6!   
�������$��0,5,0,0q�6B   .+�5�      �� #���  6(   №8 ЭНДОКРИНОЛОГ6\   � 5�      #���  6$   .+�5�   "   �� $ 
Horizontal=�6-   .+�5�   &   �� $ 
Horizontal=�61   $��Center=�6K   .+�5�   *   A� $��20��62   $��20��6>   ���	#FF01B5A66J   �� 5�   *   $
��P999��64   $��60(�6@   $��Medium"�6N   
���  ��6b   5�   '   �� 5�   &   $ 
Horizontal=�61   $��25,5,0,0q�6J   $��Center=�6\   .+�5�   *   A� $��20��62   $��20��6>   ���	#FF01B5A66I   �� 5�   *   $
��P999��64   $��60(�6@   $��Medium"�6N   
���  ��6b   5�   '   �� 5�   &   $ 
Horizontal=�61   $��25,5,0,0q�6J   $��Center=�6\   .+�5�   *   A� $��20��62   $��20��6>   ���	#FF01B5A66J   �� 5�   *   $
��P999��64   $��60(�6@   $��Medium"�6N   
���  ��6b   5�   '   5�   #   5�      5�      � 5�      $	��150��6    ���	#FFECECEC$��0,5,0,0q�6D   .+�5�      �� #���  6(   $��
25,35,0,35q�6K   №9 АЛЛЕРГОЛОГ6n   � 5�      #���  6$   .+�5�   "   �� $ 
Horizontal=�6-   .+�5�   &   �� $ 
Horizontal=�61   $��Center=�6K   .+�5�   *   A� $��20��62   $��20��6>   ���	#FF01B5A66J   �� 5�   *   $
��P999��64   $��60(�6@   $��Medium"�6N   
���  ��6b   5�   '   �� 5�   &   $ 
Horizontal=�61   $��25,5,0,0q�6J   $��Center=�6\   .+�5�   *   A� $��20��62   $��20��6>   ���	#FF01B5A66I   �� 5�   *   $
��P999��64   $��60(�6@   $��Medium"�6N   
���  ��6b   5�   '   �� 5�   &   $ 
Horizontal=�61   $��25,5,0,0q�6J   $��Center=�6\   .+�5�   *   A� $��20��62   $��20��6>   ���	#FF01B5A66J   �� 5�   *   $
��P999��64   $��60(�6@   $��Medium"�6N   
���  ��6b   5�   '   5�   #   5�      5�      � 5�      $	��150��6!   
�������$��0,5,0,0q�6B   .+�5�      �� #���  6(   №10 ЛОР6T   � 5�      #���  6$   .+�5�   "   �� $ 
Horizontal=�6-   .+�5�   &   �� $ 
Horizontal=�61   $��Center=�6K   .+�5�   *   A� $��20��62   $��20��6>   ���	#FF01B5A66J   �� 5�   *   $
��P999��64   $��60(�6@   $��Medium"�6N   
���  ��6b   5�   '   �� 5�   &   $ 
Horizontal=�61   $��25,5,0,0q�6J   $��Center=�6\   .+�5�   *   A� $��20��62   $��20��6>   ���	#FF01B5A66I   �� 5�   *   $
��P999��64   $��60(�6@   $��Medium"�6N   
���  ��6b   5�   '   �� 5�   &   $ 
Horizontal=�61   $��25,5,0,0q�6J   $��Center=�6\   .+�5�   *   A� $��20��62   $��20��6>   ���	#FF01B5A66J   �� 5�   *   $
��P999��64   $��60(�6@   $��Medium"�6N   
���  ��6b   5�   '   5�   #   5�      5�      � 5�      $	��150��6    ���	#FFECECEC$��0,5,0,0q�6D   .+�5�      �� #���  6(   $��
25,35,0,35q�6K   №11 СТОМАТОЛОГ6o   � 5�      #���  6$   .+�5�   "   �� $ 
Horizontal=�6-   .+�5�   &   �� $ 
Horizontal=�61   $��Center=�6K   .+�5�   *   A� $��20��62   $��20��6>   ���	#FF01B5A66J   �� 5�   *   $
��P999��64   $��60(�6@   $��Medium"�6N   
���  ��6b   5�   '   �� 5�   &   $ 
Horizontal=�61   $��25,5,0,0q�6J   $��Center=�6\   .+�5�   *   A� $��20��62   $��20��6>   ���	#FF01B5A66I   �� 5�   *   $
��P999��64   $��60(�6@   $��Medium"�6N   
���  ��6b   5   '   �� 5  &   $ 
Horizontal=�61   $��25,5,0,0q�6J   $��Center=�6\   .+�5  *   A� $��20��62   $��20��6>   ���	#FF01B5A66J   �� 5  *   $
��P999��64   $��60(�6@   $��Medium"�6N   
���  ��6b   5  '   5  #   5     5     5     �� 5	     -   5        $ f2��5	  .   $��1��6!   .+�5
     � $	��150��6    
�������$��0,5,0,0q�6@   .+�5     �� #���  6(   $��
25,35,0,35q�6K   №1 НЕВРОПОТОЛОГ6p   � 5     #���  6$   .+�5  "   �� $ 
Horizontal=�6-   .+�5  &   �� $ 
Horizontal=�61   $��Center=�6K   .+�5  *   A� $��20��62   $��20��6>   ���	#FF01B5A66J   �� 5  *   $
��P999��64   $��60(�6@   $��Medium"�6N   
���  ��6b   5  '   �� 5  &   $ 
Horizontal=�61   $��25,5,0,0q�6J   $��Center=�6\   .+�5  *   A� $��20��62   $��20��6>   ���	#FF01B5A66I   �� 5  *   $
��P999��64   $��60(�6@   $��Medium"�6N   
���  ��6b   5  '   �� 5  &   $ 
Horizontal=�61   $��25,5,0,0q�6J   $��Center=�6\   .+�5  *   A� $��20��62   $��20��6>   ���	#FF01B5A66J   �� 5  *   $
��P999��64   $��60(�6@   $��Medium"�6N   
���  ��6b   5  '   5  #   5     5     � 5     $	��150��6!   ���	#FFECECEC$��0,5,0,0q�6F   .+�5     �� #���  6(   №2 КАРДИОЛОГ6Y   � 5     #���  6$   .+�5   "   �� $ 
Horizontal=�6-   .+�5!  &   �� $ 
Horizontal=�61   $��Center=�6K   .+�5"  *   A� $��20��62   $��20��6>   ���	#FF01B5A66J   �� 5#  *   $
��P999��64   $��60(�6@   $��Medium"�6N   
���  ��6b   5$  '   �� 5%  &   $ 
Horizontal=�61   $��25,5,0,0q�6J   $��Center=�6\   .+�5&  *   A� $��20��62   $��20��6>   ���	#FF01B5A66I   �� 5'  *   $
��P999��64   $��60(�6@   $��Medium"�6N   
���  ��6b   5(  '   �� 5)  &   $ 
Horizontal=�61   $��25,5,0,0q�6J   $��Center=�6\   .+�5*  *   A� $��20��62   $��20��6>   ���	#FF01B5A66J   �� 5+  *   $
��P999��64   $��60(�6@   $��Medium"�6N   
���  ��6b   5,  '   5-  #   5.     5/     � 50     $	��150��6    
�������$��0,5,0,0q�6@   .+�51     �� #���  6(   $��
25,35,0,35q�6K   №3 ОФТАЛМОЛОГ6n   � 52     #���  6$   .+�53  "   �� $ 
Horizontal=�6-   .+�54  &   �� $ 
Horizontal=�61   $��Center=�6K   .+�55  *   A� $��20��62   $��20��6>   ���	#FF01B5A66J   �� 56  *   $
��P999��64   $��60(�6@   $��Medium"�6N   
���  ��6b   57  '   �� 58  &   $ 
Horizontal=�61   $��25,5,0,0q�6J   $��Center=�6\   .+�59  *   A� $��20��62   $��20��6>   ���	#FF01B5A66I   �� 5:  *   $
��P999��64   $��60(�6@   $��Medium"�6N   
���  ��6b   5;  '   �� 5<  &   $ 
Horizontal=�61   $��25,5,0,0q�6J   $��Center=�6\   .+�5=  *   A� $��20��62   $��20��6>   ���	#FF01B5A66J   �� 5>  *   $
��P999��64   $��60(�6@   $��Medium"�6N   
���  ��6b   5?  '   5@  #   5A     5B     � 5C     $	��150��6!   ���	#FFECECEC$��0,5,0,0q�6F   .+�5D     �� #���  6(   $��58(�6K   №4 ГЕПАТОЛОГ�� 6f   ГАСТРОЭНТРОЛОГ6�   � 5E     #���  6$   .+�5F  "   �� $ 
Horizontal=�6-   .+�5G  &   �� $ 
Horizontal=�61   $��Center=�6K   .+�5H  *   A� $��20��62   $��20��6>   ���	#FF01B5A66J   �� 5I  *   $
��P999��64   $��60(�6@   $��Medium"�6N   
���  ��6b   5J  '   �� 5K  &   $ 
Horizontal=�61   $��25,5,0,0q�6J   $��Center=�6\   .+�5L  *   A� $��20��62   $��20��6>   ���	#FF01B5A66I   �� 5M  *   $
��P999��64   $��60(�6@   $��Medium"�6N   
���  ��6b   5N  '   �� 5O  &   $ 
Horizontal=�61   $��25,5,0,0q�6J   $��Center=�6\   .+�5P  *   A� $��20��62   $��20��6>   ���	#FF01B5A66J   �� 5Q  *   $
��P999��64   $��60(�6@   $��Medium"�6N   
���  ��6b   5R  '   5S  #   5T     5U     � 5V     $	��150��6    
�������$��0,5,0,0q�6@   .+�5W     �� #���  6(   $��
25,35,0,35q�6K   №5 НЕФРОЛОГ6l   � 5X     #���  6$   .+�5Y  "   �� $ 
Horizontal=�6-   .+�5Z  &   �� $ 
Horizontal=�61   $��Center=�6K   .+�5[  *   A� $��20��62   $��20��6>   ���	#FF01B5A66J   �� 5\  *   $
��P999��64   $��60(�6@   $��Medium"�6N   
���  ��6b   5]  '   �� 5^  &   $ 
Horizontal=�61   $��25,5,0,0q�6J   $��Center=�6\   .+�5_  *   A� $��20��62   $��20��6>   ���	#FF01B5A66I   �� 5`  *   $
��P999��64   $��60(�6@   $��Medium"�6N   
���  ��6b   5a  '   �� 5b  &   $ 
Horizontal=�61   $��25,5,0,0q�6J   $��Center=�6\   .+�5c  *   A� $��20��62   $��20��6>   ���	#FF01B5A66J   �� 5d  *   $
��P999��64   $��60(�6@   $��Medium"�6N   
���  ��6b   5e  '   5f  #   5g     5h     � 5i     $	��150��6!   ���	#FFECECEC$��0,5,0,0q�6F   .+�5j     �� #���  6(   №6 ГЕМАТОЛОГ6Y   � 5k     #���  6$   .+�5l  "   �� $ 
Horizontal=�6-   .+�5m  &   �� $ 
Horizontal=�61   $��Center=�6K   .+�5n  *   A� $��20��62   $��20��6>   ���	#FF01B5A66J   �� 5o  *   $
��P999��64   $��60(�6@   $��Medium"�6N   
���  ��6b   5p  '   �� 5q  &   $ 
Horizontal=�61   $��25,5,0,0q�6J   $��Center=�6\   .+�5r  *   A� $��20��62   $��20��6>   ���	#FF01B5A66I   �� 5s  *   $
��P999��64   $��60(�6@   $��Medium"�6N   
���  ��6b   5t  '   �� 5u  &   $ 
Horizontal=�61   $��25,5,0,0q�6J   $��Center=�6\   .+�5v  *   A� $��20��62   $��20��6>   ���	#FF01B5A66J   �� 5w  *   $
��P999��64   $��60(�6@   $��Medium"�6N   
���  ��6b   5x  '   5y  #   5z     5{     � 5|     $	��150��6    
�������$��0,5,0,0q�6@   .+�5}     �� #���  6(   $��
25,35,0,35q�6K   №7 ПЕДИАТР6k   � 5~     #���  6$   .+�5  "   �� $ 
Horizontal=�6-   .+�5�  &   �� $ 
Horizontal=�61   $��Center=�6K   .+�5�  *   A� $��20��62   $��20��6>   ���	#FF01B5A66J   �� 5�  *   $
��P999��64   $��60(�6@   $��Medium"�6N   
���  ��6b   5�  '   �� 5�  &   $ 
Horizontal=�61   $��25,5,0,0q�6J   $��Center=�6\   .+�5�  *   A� $��20��62   $��20��6>   ���	#FF01B5A66I   �� 5�  *   $
��P999��64   $��60(�6@   $��Medium"�6N   
���  ��6b   5�  '   �� 5�  &   $ 
Horizontal=�61   $��25,5,0,0q�6J   $��Center=�6\   .+�5�  *   A� $��20��62   $��20��6>   ���	#FF01B5A66J   �� 5�  *   $
��P999��64   $��60(�6@   $��Medium"�6N   
���  ��6b   5�  '   5�  #   5�     5�     � 5�     $	��150��6!   ���	#FFECECEC$��0,5,0,0q�6F   .+�5�     �� #���  6(   №8 ЭНДОКРИНОЛОГ6\   � 5�     #���  6$   .+�5�  "   �� $ 
Horizontal=�6-   .+�5�  &   �� $ 
Horizontal=�61   $��Center=�6K   .+�5�  *   A� $��20��62   $��20��6>   ���	#FF01B5A66J   �� 5�  *   $
��P999��64   $��60(�6@   $��Medium"�6N   
���  ��6b   5�  '   �� 5�  &   $ 
Horizontal=�61   $��25,5,0,0q�6J   $��Center=�6\   .+�5�  *   A� $��20��62   $��20��6>   ���	#FF01B5A66I   �� 5�  *   $
��P999��64   $��60(�6@   $��Medium"�6N   
���  ��6b   5�  '   �� 5�  &   $ 
Horizontal=�61   $��25,5,0,0q�6J   $��Center=�6\   .+�5�  *   A� $��20��62   $��20��6>   ���	#FF01B5A66J   �� 5�  *   $
��P999��64   $��60(�6@   $��Medium"�6N   
���  ��6b   5�  '   5�  #   5�     5�     � 5�     $	��150��6    
�������$��0,5,0,0q�6@   .+�5�     �� #���  6(   $��
25,35,0,35q�6K   №9 АЛЛЕРГОЛОГ6n   � 5�     #���  6$   .+�5�  "   �� $ 
Horizontal=�6-   .+�5�  &   �� $ 
Horizontal=�61   $��Center=�6K   .+�5�  *   A� $��20��62   $��20��6>   ���	#FF01B5A66J   �� 5�  *   $
��P999��64   $��60(�6@   $��Medium"�6N   
���  ��6b   5�  '   �� 5�  &   $ 
Horizontal=�61   $��25,5,0,0q�6J   $��Center=�6\   .+�5�  *   A� $��20��62   $��20��6>   ���	#FF01B5A66I   �� 5�  *   $
��P999��64   $��60(�6@   $��Medium"�6N   
���  ��6b   5�  '   �� 5�  &   $ 
Horizontal=�61   $��25,5,0,0q�6J   $��Center=�6\   .+�5�  *   A� $��20��62   $��20��6>   ���	#FF01B5A66J   �� 5�  *   $
��P999��64   $��60(�6@   $��Medium"�6N   
���  ��6b   5�  '   5�  #   5�     5�     � 5�     $	��150��6!   ���	#FFECECEC$��0,5,0,0q�6F   .+�5�     �� #���  6(   №10 ЛОР6T   � 5�     #���  6$   .+�5�  "   �� $ 
Horizontal=�6-   .+�5�  &   �� $ 
Horizontal=�61   $��Center=�6K   .+�5�  *   A� $��20��62   $��20��6>   ���	#FF01B5A66J   �� 5�  *   $
��P999��64   $��60(�6@   $��Medium"�6N   
���  ��6b   5�  '   �� 5�  &   $ 
Horizontal=�61   $��25,5,0,0q�6J   $��Center=�6\   .+�5�  *   A� $��20��62   $��20��6>   ���	#FF01B5A66I   �� 5�  *   $
��P999��64   $��60(�6@   $��Medium"�6N   
���  ��6b   5�  '   �� 5�  &   $ 
Horizontal=�61   $��25,5,0,0q�6J   $��Center=�6\   .+�5�  *   A� $��20��62   $��20��6>   ���	#FF01B5A66J   �� 5�  *   $
��P999��64   $��60(�6@   $��Medium"�6N   
���  ��6b   5�  '   5�  #   5�     5�     � 5�     $	��150��6    
�������$��0,5,0,0q�6@   .+�5�     �� #���  6(   $��
25,35,0,35q�6K   №11 СТОМАТОЛОГ6o   � 5�     #���  6$   .+�5�  "   �� $ 
Horizontal=�6-   .+�5�  &   �� $ 
Horizontal=�61   $��Center=�6K   .+�5�  *   A� $��20��62   $��20��6>   ���	#FF01B5A66J   �� 5�  *   $
��P999��64   $��60(�6@   $��Medium"�6N   
���  ��6b   5�  '   �� 5�  &   $ 
Horizontal=�61   $��25,5,0,0q�6J   $��Center=�6\   .+�5�  *   A� $��20��62   $��20��6>   ���	#FF01B5A66I   �� 5�  *   $
��P999��64   $��60(�6@   $��Medium"�6N   
���  ��6b   5�  '   �� 5�  &   $ 
Horizontal=�61   $��25,5,0,0q�6J   $��Center=�6\   .+�5�  *   A� $��20��62   $��20��6>   ���	#FF01B5A66J   �� 5�  *   $
��P999��64   $��60(�6@   $��Medium"�6N   
���  ��6b   5�  '   5�  #   5�     5�     5�     5�     5�     5�     � 5�  
   $��1��6   ���#01B5A6 � ColumnDefinitions 5�     �� 5�     $��* �6#   �� 5�     $
��Auto �6#   .+�5�     (� $	��120��6   $��0��6$   $��Stretch=�64   $��30,0,0,0q�6R   .��5�     �� $��70(�6   $��Center=�6*   
�������$��Center=�6Z   $
��1000��6w   $��№2 КАРДИОЛОГ��6�   $
��Wrap=�6�   $��0��6�   6�   5�     � 5�     $
��Auto��6   $��Right=�6!   $
��Auto��6=   $��1��6J   .+�5�     �� $ 
Horizontal=�6   .+�5�     �� $��90(�6    $��Center=�6.   $
��P777��6I   $��Right=�6U   ��5�     �� 5�     -   5        buttonColor�� �� Color$ White��5�  C   5�     � 5�     $	��120��6   $	��120��6'   $��	20,0,50,0q�64   .+�5�     F� -   5         F�Name$ path2��5�     
�������$��5��6=    �� Stretch$
 Fill=�6R   !���Ѐ�����׀��      ��	$��58.667,30,28.959,29.667q�6�   $y�	Collapsed=�6�   F� 5�     -	   5        $ path1��5�     
�������$��5��6=   $
 Fill=�6R   !���Ѐ�����׀��      ��	$��58.667,38.5,37.75,38q�6�   $y�	Collapsed=�6�   F� 5�     -
   5        $
 path��5�     
�������$��5��6<   $
 Fill=�6Q   !���Ѐ�����׀��      ��	$��58.667,48,46.667,47.328q�6�   $y�	Collapsed=�6�   �� 5�     $��Image/Kol.png��6    $	��100��67   $	��100��6D   $��-7.334,10,27.333,10q�6P   5�     5�     5�     5�     5�     5�     