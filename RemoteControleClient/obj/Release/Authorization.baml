   M S B A M L   `   `   `  ����   RemoteControleClient(    "RemoteControleClient.Authorization   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     -     �Name$  
AuthWindow�� � Title$ Authorization��$	��435��$	��452����Z�  � 	Resources  �� MergedDictionaries �� Source��  �� $ Styles.xaml?�%    ����  �� EndPoint$ 0.5,1&� �� 
StartPoint$ 0.5,0&�.���  � Color$ Black�� � Offset$ 0Q�� $ 	#FF0D54EE��$ 0.297Q�.��� .+��� -   	 ��Name$	 MyTab����Z� ��Z� .@��� $��Authorization��$	��150��$��50��
 J� RenderTransformOrigin$
 0.5,0.5&�#��� ������ $ 0.5,1&�$ 0.5,0&�.��� $ Black��$ 0.153Q�� $ 	#FFE23B16��$ 0.837Q����� $ 0.5,1&�$ 0.5,0&�.��� $ Black��$ 0Q�� $ 	#FF25B60F��$ 1Q�z�V� .~��� ��  �� AngleX$	 -25Q��� T�  T� X$ 15Q� J� Effect 3  -System.Windows.Media.Effects.DropShadowEffect     ShadowDepth$ 10Q�   Color$ 	#FFF3FF00��.��� ���� $ 0.5,1&�$ 0.5,0&�.��� $ Black��$ 0Q�� $ 	#FF0F96E4��$ 1Q�.+��� -    ��Name$ 
tbUserName��   GlassTextBoxOne#���   $
��Left=�$��40��$��
133,39,0,0q� �� TextWrapping$
 Wrap=�$��Введите логин��$	��Top=�$	��265��$��16(��� -   $ 
tbPassword��#���   $
��Left=�$��39��$��133,100,0,0q�$
 Wrap=�$!��Введите пароль��$	��Top=�$	��265��$��16(��� $��Username : ��$
��Left=�$��	10,42,0,0q�$	��Top=�$��Italic$�$��Hobo Std)�$��18.667(����� $ 0.5,1&�$ 0.5,0&�.��� $ Black��$
 0.17Q�� $ 	#FFFF0303��$ 0.583Q�� $ 	#FFB85151��$ 0.733Q��� $��Password : ��$
��Left=�$��
13,100,0,0q�$	��Top=�$	��109��$��Italic$�$��Hobo Std)�$��18.667(����� $ 0.5,1&�$ 0.5,0&�.��� $ Black��$
 0.17Q�� $ 	#FFFF0303��$ 0.583Q�� $ 	#FFB85151��$ 0.733Q��� -    ��Name$ 	Ok_button��  controlButtonTemplate2#���  $��OK��$
��Left=�$��
47,186,0,0q�$	��Top=�$��75���� -   $ For_p_button��#���  $��?��$
��Left=�$��354,186,0,0q�$	��Top=�$��44���� -   $ Help_button��#���  $��Forgot password��$
��Left=�$��127,186,0,0q�$	��Top=�$	��227���� $��Registration��$	��150��$
 0.5,0.5&����� $ 0.5,1&�$ 0.5,0&�.��� $ Black��$ 0.207Q�� $ 	#FF22F90C��$
 0.75Q����� $	 0,1&�$	 0,0&�.��� $ 	#FFF3F3F3��$ 0Q�� $ 	#FFEBEBEB��� $ 	#FFDDDDDD��� $ 	#FF600CB4��� $ 	#FF1B0CB4��$ 0.453Q�� $ 	#FFB40C60��$ 0.903Q�   $ 10Q�$ 	#FF00F4FF��z�V� .~��� �� $	 -25Q��� T� $ 15Q�.��� ���� $ 0.5,1&�$ 0.5,0&�.��� $ Black��$
 0.02Q�� $ 	#FF00FFDC��$ 0.343Q�� $ 	#FF059C73��$ 0.633Q�.+��� -   $ textUserName��  GlassTextBoxThree#���  $
��Left=�$��38��$��
156,95,0,0q�$
 Wrap=�$	��Top=�$	��265��$��16(�$y�Hidden=��� -	   $ textPassword��  GlassTextBoxFour#���  $
��Left=�$��37��$��156,138,0,0q�$
 Wrap=�$	��Top=�$	��265��$��16(�$y�Hidden=��� -
    ��Name$ labusername��$��Username : ��$
��Left=�$��	12,93,0,0q�$	��Top=�$��18.667(�$��40��$y�Hidden=����� $ 0.5,1&�$ 0.5,0&�.��� $ Black��$ 0Q�� $ 	#FFFF0097��$ 0.593Q��� -   $ labpassword��$��Password : ��$
��Left=�$��
13,135,0,0q�$	��Top=�$	��107��$��18.667(�$��40��$y�Hidden=����� $ 0.5,1&�$ 0.5,0&�.��� $ Black��$ 0Q�� $ 	#FFFF0097��$ 0.593Q��� -   $ 
Reg_button��  GlassButtonFour#���  $��Register��$
��Left=�$��145,280,0,0q�$	��Top=�$	��164��$��44��$��26.667(�$y�Hidden=��� -   $ textFirstName��#���   $
��Left=�$��36��$��
156,14,0,0q�$
 Wrap=�$	��Top=�$	��265��$��16(�$y�Hidden=��� -   $ textLastName��  GlassTextBoxTwo#���  $
��Left=�$��40��$��
156,55,0,0q�$
 Wrap=�$	��Top=�$	��265��$��16(�$y�Hidden=��� -   $ labfirstName��$��First name : ��$
��Left=�$��	10,11,0,0q�$	��Top=�$��18.667(�$��39��$y�Hidden=����� $ 0.5,1&�$ 0.5,0&�.��� $ Black��$ 0Q�� $ 	#FFFF0097��$ 0.593Q��� -   $ lablastname��$��Last name : ��$
��Left=�$��	13,55,0,0q�$	��Top=�$��72��$��18.667(�$��40��$y�Hidden=����� $ 0.5,1&�$ 0.5,0&�.��� $ Black��$ 0Q�� $ 	#FFFF0097��$ 0.593Q��� -   $ textHelp��  GlassTextBoxFive#���  $
��Left=�$��38��$��156,180,0,0q�$
 Wrap=�$	��Top=�$	��265��$��16(�$y�Hidden=��� -   $ 	textEmail��#���   $
��Left=�$��37��$��156,223,0,0q�$
 Wrap=�$	��Top=�$	��265��$��16(�$y�Hidden=��� -   $ labhelp��$��Help question : ��$
��Left=�$��
12,178,0,0q�$	��Top=�$	��135��$
 
0.72,0.692&�$��18.667(�$��40��$y�Hidden=����� $ 0.5,1&�$ 0.5,0&�.��� $ Black��$ 0Q�� $ 	#FFFF0097��$ 0.593Q��� -   $ labEmail��$��	E-mail : ��$
��Left=�$��
12,221,0,0q�$	��Top=�$	��108��$��18.667(�$��39��$
 0.519,1.795&�$y�Hidden=����� $ 0.5,1&�$ 0.5,0&�.��� $ Black��$ 0Q�� $ 	#FFFF0097��$ 0.593Q�G� -    G�Name$ 	AdminPass��$
��Left=�$��
13,133,0,0q�$	��Top=�$	��408��$��62��$��48(��� -   $ labAdminPass��$��Admin Password��$
��Left=�$��	85,55,0,0q�$	��Top=�$��36(�