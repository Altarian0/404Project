   M S B A M L   `   `   `  ����E  A404Project, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]3clr-namespace:_404Project.VIews.Forms.ProductFolder%_404Project.VIews.Forms.ProductFolder  5   	   ;    5_404Project.VIews.Forms.ProductFolder.EditProductPage   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Elocal3clr-namespace:_404Project.VIews.Forms.ProductFolder     5   	   -   5          � Title$/  )Редактирование товара��5   	   $	��450��6'   $	��800��64    � 
ResizeMode$ NoResize=�6@   .��5	      � .+�5
   
   �� -   5         ��Name$
 Name��5
      $	��500��6    $��35��6C   $
��Left=�6O   $	��Top=�6j   $��
200,57,0,0q�6�   ��6,   �� *Name+6�   �� 5   
   $��Название��6   $��14(�6$    �� TextAlignment$ Center=�63   $	��200��6J   $
��Left=�6V   $	��Top=�6q   $��0,66,0,0q�6�   �� 5   
   -   5        $ Description��5      $	��500��6(   $��84��6R   $
��Left=�6^   $	��Top=�6y   $��
200,97,0,0q�6�   ��64   �� *Description+6�   �� 5   
   $��Описание��6   $��14(�6$   $ Center=�63   $	��200��6J   $
��Left=�6V   $	��Top=�6q   $��	0,104,0,0q�6�   �� 5   
   -   5        $ PriceBox��5      $	��500��6$   $��35��6H   $
��Left=�6T   $	��Top=�6o   $��200,185,0,0q�6�   ��60   �� *Price+6�   �� 5   
   $��14(�6   $ Center=�6#   $	��200��6:   $
��Left=�6F   $	��Top=�6a   $��
-2,185,0,0q�6y   �� 6�   $�
Цена (��6�   �� 6�   $�Руб)��6�   6�   �� 5   
   -   5         ��Name$ SaveBtn��5      $��Right=�6"   $��Сохранить��6>   $��40��6R   $	��150��6^   $��Bottom=�6j   $��0,0,19.6,10q�6�   6�   �� 5   
   -   5        $ 	CancelBtn��5      $��Right=�6$   $��Закрыть��6@   $��40��6R   $	��150��6^   $��Bottom=�6j   $��0,0,174.6,10q�6�   6�   �� 5   
   -   5        $ ImageLinkBox��5      $	��352��6(   $�� ��64   $��35��6d   $
��Left=�6p   $	��Top=�6�   $��200,225,0,0q�6�   �� 5   
   $��14(�6   $ Center=�6#   $	��200��6:   $
��Left=�6F   $	��Top=�6a   $��
-2,231,0,0q�6y   �� 6�   $�Фотографии(��6�   �� 6�   $�Ссылка)��6�   6�   �� 5   
   -   5         ��Name$ 
PictureBox��5      $
��Fill=�6$   $��0,0,549.6,10q�6P    J� RenderTransformOrigin$ 0.5,0.5&�6f   $	��145��6�   $��Bottom=�6�   $��Right=�6�   $	��214��6�   ��63   �� *	LogoImage+6�   �� 5   
   -	   5        $ AddImageBtn��5      $
��Left=�6&   $��Добавить��6A   $��35��6T   $	��134��6`   $	��Top=�6l   $��269,281,0,0q�6�   6�   5      5      