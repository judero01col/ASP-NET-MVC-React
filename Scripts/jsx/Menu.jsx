
class NavMenu extends React.Component {
    render() {
        console.log("Hello World React JS! from react");
        return (
            <div className='main-nav'>
                <div className='navbar navbar-inverse'>
                    <div className='navbar-header'>
                        <button type='button' className='navbar-toggle' data-toggle='collapse' data-target='.navbar-collapse'>
                            <span className='sr-only'>Toggle navigation</span>
                            <span className='icon-bar'></span>
                            <span className='icon-bar'></span>
                            <span className='icon-bar'></span>
                        </button>
                        <Link className='navbar-brand' to={'/'}>ReactCrudDemo</Link>
                    </div>
                    <div className='clearfix'></div>
                    <div className='navbar-collapse collapse'>
                        <ul className='nav navbar-nav'>
                            <li>
                                <NavLink to={'/'} exact activeClassName='active'>
                                    <span className='glyphicon glyphicon-home'></span> Home
                            </NavLink>
                            </li>
                            <li>
                                <NavLink to={'/fetchemployee'} activeClassName='active'>
                                    <span className='glyphicon glyphicon-th-list'></span> Fetch employee
                            </NavLink>
                            </li>
                        </ul>
                    </div>
                </div>
            </div>
        )
    }
}



