   M S B A M L   `   `   `  ����D  @Kinoteatr, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Kinoteatr	Kinoteatr  5          Kinoteatr.Gost   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      )localclr-namespace:Kinoteatr     5      _ [MaterialDesignThemes.Wpf, Version=4.8.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5        N� Title$
  Gost��5	      $	��450��6   $	��800��6!   .��5      � ��5   
   
� 5      .��5      �  � Color$ 	#FF3B44C3��6    � Offset$ 0.592Q�61   � 5      $ Black��6   $ 1Q�6-   5       � RowDefinitions 5   
   �� 5      $	��52* �6   �� 5      $	��41* �6   �� 5      $
��357* �6   .+�5   
   �� -   5        $��MainListView��5   "   $��2��6   ��5      �� 5       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5      � $ Black��6#   � 5      $ 	#FF940A0A��6#   $ 1Q�65   5      ��5      �� 5      .R�5       �  5!      �� 5"      $
��200* �6,   6<   .+�5'      ��  ��Name$ 
MainBorder��6A   -   5        
�������$��0��5'   4    �� Padding$ 30q�6�   $	��770��6�    �� CornerRadius$ 20��6�   $��Center=�6�   ._�5(      �� 	 �� Orientation$	 
Horizontal=�6)   $��0,10,0,0q�6B   .+�5)   "   �� $	��150��6C   $	��100��6O   $
��Left=�6\   ��6(   �� *Photo+6\   �� 5*   "   $
��Wrap=�6F   $	��100��6Z   $	��400��6g   $��Comic Sans MS)�6s   $��12(�6�   $	��Top=�6�   $��Center=�6�   ��6,   �� *
Opisanie+6�   5/      51      �� 53      $��Comic Sans MS)�6>   $��
10,5,10,10q�6Y   $��20(�6o   $	��Top=�6~   $��Center=�6�   ��6$   �� *
NameFilm+6�   �� 54      $��Comic Sans MS)�6B   $��20(�6_   $��
690,10,0,0q�6m   $	��Top=�6�   $��Center=�6�   ��6$   �� *Ogranichenie+6�   �� 55      $)��#Продолжительность:��6    $��580,100,0,0q�6=   
���  ��$��15(�6c   �� 56      $��Comic Sans MS)�6?   $	��120��6Z   $��15(�6g   $��520,130,0,1q�6v   ��6$   �� *	Time_Film+6v   �� 57      $��Страна:��6    $��
580,70,0,0q�62   $��15(�6G   �� 58      $��Comic Sans MS)�6=   $	��120��6X   $��15(�6e   $��520,75,-110,1q�6t   ��6$   �� *	Country+6t   �� 59      $��Comic Sans MS)�6:   $��
300,10,0,0q�6U   $��15(�6j   $	��Top=�6y   $��Center=�6�   ��6$   �� *Zanr+6�   5>      5?      5B      �� 5D   
   
�������$!��Список фильмов��6'   $��Center=�6@   $��Center=�6[   $��35(�6x   $��Comic Sans MS)�6�   $��50��6�   $	��312��6�   �� 5F   
   -   5        $��
Назад��5F      $
��Left=�6!   $��10,4,0,0q�6<   $��32��6N   $	��Top=�6Z   6r   �� 5H   
   -   5        
 ��Name$
 GenreComboBox��5H      
�������$��1��6E   $��10,10,635,0q�6R   $	��Top=�6�   5K      �� 5M   
   -   5        $
 AgeComboBox��5M      
�������$��1��6D   $��
638,6,10,0q�6R   $	��Top=�6�   5P      �� 5Q   
   $<��6Или введите несколько жанров:��6   
�������$��15(�6O   $
��Left=�6]   $��
170,12,0,0q�6x   $��1��6�   $	��Top=�6�   �� 5R   
   -   5         ��Name$ GenreTextBox��5R   -   $
��Left=�6   $��
400,13,0,0q�6C   $��1��6~    �� TextWrapping$
 Wrap=�6�   
�������$	��Top=�6�   $	��233��6�   5V      5W      