   M S B A M L   `   `   `  ����E  A404Project, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:_404Project.VIews.Pages_404Project.VIews.Pages  5      )    #_404Project.VIews.Pages.ProductPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      7local%clr-namespace:_404Project.VIews.Pages     5        N� Title$  Товары��5	      .��5      � 
�������.+�5   
   �� -   5         ��Name$ ProductsView��5      ��.  $��Visible=�6O   $��55,118,46,32.6q�6�   ��5      �� 5      .R�5      � $��5q�6     � Orientation$ Vertical=�6+   .+�5      �� $��	0 0 20 00q�6$   ��67   �� *Name+ �� StringFormat$ Товар: {0}���� 5      $
��Wrap=�6$   ��68   �� *Description+$ Описание: {0}���� 5      ��6%   �� *Price+$ Цена: {0} руб.���� 5       �� Orientation$ Horizontal =�6&   $��Bottom=�6@   $
��Left=�6[   .+�5      �� $
��Wrap=�6(   $��Bottom=�6<   $
��Left=�6W   $��18(�6s   ��6�   �� *RatingProduct+$ Рейтинг: {0}���� 5      $��10��6$   $��10��60   $��5 0 0 0q�6;   $
��Left=�6L   $
��Fill=�6g   $A��;/404Project;component/Resources/outline_star_black_24dp.png��6v   5      �� 5      {�.  ��6#   �� *ProductImage+��5      �� 5   "   .R�5   &   �� $ 
Horizontal=�61   5   #   ��5      �� 5    "   .R�5!   &   �� $ 
Horizontal=�61   .+�5"   *   �� $��0q�60   $��50��6;   $��50��6F   ��6R   �� *Source+5#   '   5$   #   5&      5'      5)      5,      �� 5-   
   -   5         ��Name$ EditShop��5-      $��Right=�6#   $��Изменить��6?   $��40��6R   $	��150��6^   $	��Top=�6j   $��
0,10,199,0q�6�   6�   �� 5.   
   -   5        $ AddBtn��5.      $��Right=�6!   $��Добавить��6=   $��40��6P   $	��150��6\   $	��Top=�6h   $��	0,10,44,0q�6�   6�   �� 5/   
   -   5        $ 	DeleteBtn��5/      $��Right=�6$   $��Удалить��6@   $��40��6R   $	��150��6^   $	��Top=�6j   $��
0,10,360,0q�6�   6�   �� 50   
   -   5        $ 
CommentBtn��50      $��Комментарии��6%   $��	33,10,0,0q�6;   $
��Left=�6g   $	��150��6�   $��40��6�   $	��Top=�6�   �� 51   
   -   5         ��Name$ 	SearchBox��51      $	��201��6%   $��35��6V   $
��Left=�6b   $	��Top=�6}   $��
129,69,0,0q�6�   �� 52   
   $��Поиск ��6   $��14(�6"    �� TextAlignment$ Center=�60   $��82��6G   $
��Left=�6R   $	��Top=�6m   $��	56,74,0,0q�6�   53      54      